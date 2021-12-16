using FapClient.Core.Repository;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FapClient.GUI
{
    public partial class Form1 : Form
    {
        private readonly ICampusRepository campusRepository = new CampusRepository();
        private readonly ITermRepository termRepository = new TermRepository();
        private readonly ISubjectRepository subjectRepository = new SubjectRepository();
        private readonly IStudentRepository studentRepository = new StudentRepository();
        private readonly IStudentAttendentRepository studentAttendentRepository = new StudentAttendentRepository();
        private readonly IInstructorRepository instructorRepository = new InstructorRepository();
        private readonly IRoomRepository roomRepository = new RoomRepository();

        public Form1()
        {
            InitializeComponent();
            LoadCampusList();
        }

        private void LoadCampusList()
        {
            cbbCampus.DataSource = campusRepository.GetAll();
            cbbCampus.DisplayMember = "CampusName";
            cbbCampus.ValueMember = "CampusName";
            cbbCampus.SelectedIndex = -1;
        }

        private void LoadStudentList()
        {
            if (cbbCampus.SelectedIndex != -1)
            {
                var campus = cbbCampus.SelectedValue.ToString();
                lboxStudent.DataSource = studentRepository.GetAllByCampus(campus);
                lboxStudent.DisplayMember = "FullName";
                lboxStudent.ValueMember = "StudentId";
            }
        }

        private void LoadTermList()
        {
            if (lboxStudent.SelectedIndex != -1)
            {
                var id = Convert.ToInt32(lboxStudent.SelectedValue.ToString());
                cbbTerm.DataSource = termRepository.GetByStudent(id);
                cbbTerm.DisplayMember = "TermName";
                cbbTerm.ValueMember = "TermId";
            }
        }

        private void LoadSubjectList()
        {
            if (lboxStudent.SelectedIndex != -1)
            {
                var sId = Convert.ToInt32(lboxStudent.SelectedValue.ToString());
                var tId = Convert.ToInt32(cbbTerm.SelectedValue.ToString());
                lboxCourse.DataSource = subjectRepository.GetByStudentAndTerm(sId, tId);
                lboxCourse.DisplayMember = "SubjectName";
                lboxCourse.ValueMember = "SubjectId";
            }
        }

        public void LoadReport()
        {
            if (lboxCourse.SelectedIndex != -1)
            {
                var sId = Convert.ToInt32(lboxStudent.SelectedValue.ToString());
                var tId = Convert.ToInt32(cbbTerm.SelectedValue.ToString());
                int subId = 30;
                int tempSubId;
                if (Int32.TryParse(lboxCourse.SelectedValue.ToString(), out tempSubId))
                {
                    subId = tempSubId;
                }
                dgv.DataSource = studentAttendentRepository.GetStudent(sId, subId, tId);
                dgv.Columns[0].Visible = false; //RollCallBookId
                dgv.Columns[1].Visible = false; //TeachingScheduleId
                dgv.Columns[2].Visible = false; //StudentId
                dgv.Columns["TeachingDate"].DisplayIndex = 0;
                dgv.Columns["TeachingDate"].HeaderText = "Date";
                dgv.Columns["RoomId"].HeaderText = "Room";
                dgv.Columns["InstructorId"].HeaderText = "Lecturer";
                dgv.Columns["IsAbsent"].HeaderText = "Attendance Status";
            }
        }

        private void cbbCampus_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            LoadStudentList();
        }

        private void lboxStudent_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lboxStudent.SelectedIndex != -1)
            {
                var id = Convert.ToInt32(lboxStudent.SelectedValue.ToString());
                txtStudent.Text = studentRepository.GetById(id).FullName;
                LoadTermList();
                LoadSubjectList();
            }
        }

        private void lboxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxCourse.SelectedIndex != -1)
            {
                LoadReport();
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string s = string.Format("{0:dddd dd/MM/yyyy}", e.Value);
                e.Value = s;
            }

            if (e.ColumnIndex == 4)
            {
                var room = roomRepository.GetById(Convert.ToInt32(e.Value.ToString()));
                e.Value = room.RoomCode;
            }

            if (e.ColumnIndex == 5)
            {
                var instructor = instructorRepository.GetById(Convert.ToInt32(e.Value.ToString()));
                if (instructor != null)
                {
                    string s = instructor.InstructorFirstName + instructorRepository.GetFirstLetter(instructor.InstructorLastName)
                        + instructorRepository.GetFirstLetter(instructor.InstructorMidName);
                    e.Value = s;
                }
            }

            if (e.ColumnIndex == 7)
            {
                if ((bool)e.Value)
                {
                    e.Value = "Present";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Absent";
                    e.CellStyle.ForeColor = Color.Red;
                }
                if (e.Value == null)
                {
                    e.Value = "Future";
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rollCallBookId;
            int teachingScheduleId;
            
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                rollCallBookId = Convert.ToInt32(row.Cells[0].Value.ToString());
                teachingScheduleId = Convert.ToInt32(row.Cells[1].Value.ToString());
                EditForm editForm = new EditForm(rollCallBookId, teachingScheduleId);
                editForm.ShowDialog();
                LoadReport();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtStudent.Text))
                {
                    LoadStudentList();
                }
                else
                {
                    Search();
                }
            }
        }

        private void Search()
        {
            var students = studentRepository.Search(txtStudent.Text);
            lboxStudent.DataSource = students;
            lboxStudent.DisplayMember = "FullName";
            lboxStudent.ValueMember = "StudentId";
        }
    }
}
