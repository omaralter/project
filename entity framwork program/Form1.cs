using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entity_framwork_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dep_Click(object sender, EventArgs e)
        {
            frm_department dep = new frm_department();
            dep.Show();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            frm_student dep = new frm_student();
            dep.Show();
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            frm_subject sub = new frm_subject();
            sub.Show();
        }

        private void btn_subjectlecture_Click(object sender, EventArgs e)
        {
            frm_subjectlecture sublec = new frm_subjectlecture();
            sublec.Show();
        }
    }
}
