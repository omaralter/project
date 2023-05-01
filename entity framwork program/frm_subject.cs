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
    public partial class frm_subject : Form
    {
        TCCEntities db = new TCCEntities();
        Subject sub = new Subject();
        Department dep = new Department();

        int id;
        int dep_id;
        public frm_subject()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            db = new TCCEntities();
            dataGridView1.DataSource = db.Subjects.ToList();
            dataGridView2.DataSource = db.Departments.ToList();


        }

        private void btn_sub_save_Click(object sender, EventArgs e)
        {
            try
            {
                sub.Name = textBox1.Text;
                sub.MinimumDegree = int.Parse(textBox2.Text);
                sub.Term = short.Parse(textBox3.Text);
                sub.Year = short.Parse(textBox4.Text);
                sub.DepartmentId = dep_id;
                db.Entry(sub).State = EntityState.Added;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data added");
                textBox1.Text="";
                textBox2.Text="";
                textBox3.Text="";
                textBox4.Text="";
                textBox5.Text = "";
                
            }
            catch
            {
                MessageBox.Show("can not added data");
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dep_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            textBox5.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            textBox1.Text =Convert.ToString( dataGridView1.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);

        }

        private void btn_sub_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new TCCEntities();
                sub = new Subject();
                sub.id = id;
                sub.Name = textBox1.Text;
                sub.MinimumDegree = int.Parse(textBox2.Text);
                sub.Term = short.Parse(textBox3.Text);
                sub.Year = short.Parse(textBox4.Text);
                sub.DepartmentId = dep_id;
                db.Entry(sub).State = EntityState.Modified;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data added");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                
            }
            catch
            {
                MessageBox.Show("can not edited data");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btn_sub_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new TCCEntities();
                sub = new Subject();
                sub.id = id;

                db.Entry(sub).State = EntityState.Deleted;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data added");

            }
            catch
            {
                MessageBox.Show("can not edited data");
            }
        }
    }
}
