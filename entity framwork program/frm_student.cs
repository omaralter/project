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
    public partial class frm_student : Form
    {
        TCCEntities db = new TCCEntities();
        Student std = new Student();
        Department dep = new Department();

        int id;
        int dep_id;
        public frm_student()
        {
            InitializeComponent();
            LoadData();

        }
        private void LoadData()
        {
            db = new TCCEntities();
            dataGridView2.DataSource = db.Departments.ToList();
            dataGridView1.DataSource = db.Students.ToList();
        }

        private void btn_std_save_Click(object sender, EventArgs e)
        {
            try
            {


                std.Username = textBox1.Text;
                std.Firstname = textBox2.Text;
                std.Lastname = textBox3.Text;
                std.Email = textBox4.Text;
                std.Phone = textBox5.Text;
                std.RegisterDate = textBox6.Text;
                std.DepartmentId = dep_id;
                db.Entry(std).State = EntityState.Added;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data added");
                std.Username ="";
                std.Firstname = "";
                std.Lastname = "";
                std.Email = "";
                std.Phone = "";
                std.RegisterDate = "";


            }
            catch
            {
                MessageBox.Show("can not add data");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dep_id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                textBox7.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            }
            catch
            {
                MessageBox.Show("no data");
            }

        }

        private void btn_std_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new TCCEntities();
                std = new Student();
                std.id = id;
                std.Username = textBox1.Text;
                std.Firstname = textBox2.Text;
                std.Lastname = textBox3.Text;
                std.Email = textBox4.Text;
                std.Phone = textBox5.Text;
                std.RegisterDate = textBox6.Text;
                std.DepartmentId = dep_id;
                db.Entry(std).State = EntityState.Modified;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data edited");
                std.Username = "";
                std.Firstname = "";
                std.Lastname = "";
                std.Email = "";
                std.Phone = "";
                std.RegisterDate = "";


            }
            catch
            {
                MessageBox.Show("can not add data");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            textBox4.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            textBox5.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            textBox6.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void btn_std_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new TCCEntities();
                std = new Student();
                std.id = id;
                
                db.Entry(std).State = EntityState.Deleted;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data deleted");
                


            }
            catch
            {
                MessageBox.Show("can not delete data");
            }
        }
    }
}
