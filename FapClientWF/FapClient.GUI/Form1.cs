using FapClient.Core.Repository;
using System;
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

        private void LoadReport()
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
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;
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

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            string search = txtStudent.Text;
            if (!string.IsNullOrEmpty(search))
            {

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
            if (e.ColumnIndex == 5)
            {
                string s = string.Format("{0:dddd dd/MM/yyyy}", e.Value);
                e.Value = s;
            }

            if (e.ColumnIndex == 3)
            {
                var room = roomRepository.GetById(Convert.ToInt32(e.Value.ToString()));
                e.Value = room.RoomCode;
            }

            if (e.ColumnIndex == 4)
            {
                var instructor = instructorRepository.GetById(Convert.ToInt32(e.Value.ToString()));
                if (instructor != null)
                {
                    string s = instructor.InstructorFirstName + instructorRepository.GetFirstLetter(instructor.InstructorLastName)
                        + instructorRepository.GetFirstLetter(instructor.InstructorMidName);
                    e.Value = s;
                }
            }

            if (e.ColumnIndex == 6)
            {
                if ((bool)e.Value)
                {
                    e.Value = "Present";
                }
                else
                {
                    e.Value = "Absent";
                }
                if (e.Value == null)
                {
                    e.Value = "Future";
                }
            }
        }
    }
}
