using FapClient.Core.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FapClient.GUI
{
    public partial class EditForm : Form
    {
        private int rollCallBookId;
        private int teachingScheduleId;
        private IStudentAttendentRepository studentAttendentRepository = new StudentAttendentRepository();
        private IStudentRepository studentRepository = new StudentRepository();
        private IRoomRepository roomRepository = new RoomRepository();
        private ICourseScheduleRepository courseScheduleRepository = new CourseScheduleRepository();
        private IRollCallBookRepository rollCallBookRepository = new RollCallBookRepository();

        public EditForm()
        {
            InitializeComponent();
            //rollCallBookId = Form1.rollCallBookId;
            //teachingScheduleId = Form1.teachingScheduleId;
        }
        public EditForm(int rollCallBookId,int teachingScheduleId)
        {
            InitializeComponent();
            this.rollCallBookId = rollCallBookId;
            this.teachingScheduleId = teachingScheduleId;
        }
        private void LoadForm()
        {
            Dictionary<int, int> listSlot = new Dictionary<int, int>();
            for (int i = 1; i < 9; i++)
            {
                listSlot.Add(i, i);
            }
            cbbSlot.DataSource = new BindingSource(listSlot, null);
            cbbSlot.DisplayMember = "Key";
            cbbSlot.ValueMember= "Value";

            var studentAttent = studentAttendentRepository.GetDetails(rollCallBookId, teachingScheduleId);
            if (studentAttent != null)
            {
                tbStudentName.Text = studentRepository.GetById(studentAttent.StudentId).FullName;
                if (studentAttent.TeachingDate != null)
                {
                    dtpTeachDate.Value = (DateTime)studentAttent.TeachingDate;
                }
                if (studentAttent.Slot != null)
                {
                    cbbSlot.SelectedValue = (int)studentAttent.Slot;
                }
                cbbRoom.DataSource = roomRepository.GetAll();
                cbbRoom.DisplayMember = "RoomCode";
                cbbRoom.ValueMember = "RoomId";
                cbbRoom.SelectedValue = studentAttent.RoomId;
                if (studentAttent.IsAbsent != null && (bool)studentAttent.IsAbsent)
                {
                    rbPresent.Checked = true;
                }
                else
                {
                    rbAbsent.Checked = true;
                }
                rtbComment.Text = studentAttent.Comment;
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var rollCallBook = rollCallBookRepository.GetById(rollCallBookId);
            var courseSchedule = courseScheduleRepository.GetById(teachingScheduleId);
            if(rollCallBook != null && courseSchedule != null)
            {
                rollCallBook.IsAbsent = true ? rbPresent.Checked : rbPresent.Checked;
                rollCallBook.Comment = rtbComment.Text;
                courseSchedule.RoomId = Convert.ToInt32(cbbRoom.SelectedValue.ToString());
                courseSchedule.TeachingDate = dtpTeachDate.Value;
                courseSchedule.Slot = Convert.ToInt32(cbbSlot.SelectedValue.ToString());
                rollCallBookRepository.Update(rollCallBook);
                courseScheduleRepository.Update(courseSchedule);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
