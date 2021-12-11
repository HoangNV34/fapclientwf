using FapClient.Core.Models;
using FapClient.Core.Repository;
using System;
using System.Windows.Forms;

namespace FapClient.GUI
{
    public partial class Form1 : Form
    {
        private readonly ICampusRepository campusRepository = new CampusRepository();
        private readonly ITermRepository termRepository = new TermRepository();
        private readonly ICourseRepository courseRepository = new CourseRepository();
        private readonly IStudentRepository studentRepository = new StudentRepository();

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
            }
        }

        private void txtStudent_TextChanged(object sender, EventArgs e)
        {
            string search = txtStudent.Text;
            if (!string.IsNullOrEmpty(search))
            {
                lboxStudent.ClearSelected();
                for(int i = lboxStudent.Items.Count-1; i >=0; i--)
                {
                    if (lboxStudent.Items[i].ToString().ToLower().Contains(search.ToLower()))
                    {
                        lboxStudent.SetSelected(i, true);
                        break;
                    }
                }
            }
        }
    }
}
