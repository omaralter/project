using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace entity_framwork_program
{
    public partial class frm_subjectlecture : Form
    {
        TCCEntities db = new TCCEntities();
        Subject sub = new Subject();
        SubjectLecture sublec = new SubjectLecture();

        int id;
        int sub_lec;
        public frm_subjectlecture()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            db = new TCCEntities();
            dataGridView1.DataSource = db.SubjectLectures.ToList();
            dataGridView2.DataSource = db.Subjects.ToList();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sub_lec =Convert.ToInt32( dataGridView2.CurrentRow.Cells[0].Value);
            textBox3.Text =Convert.ToString( dataGridView2.CurrentRow.Cells[1].Value);
        }

        private void btn_sublec_save_Click(object sender, EventArgs e)
        {
            //sublec.Title = textBox1.Text;
            //sublec.Content = textBox2.Text;
            //db.Entry(sublec).State = EntityState.Added;
            //db.SaveChanges();
            //LoadData();
            //MessageBox.Show("data added");
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";

        }
    }
}
