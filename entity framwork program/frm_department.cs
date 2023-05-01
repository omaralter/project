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
    public partial class frm_department : Form
    {
        TCCEntities db=new TCCEntities();
        Department dep=new Department();
        int id;
        public frm_department()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            db = new TCCEntities();
            dataGridView1.DataSource = db.Departments.ToList();
        }

        private void btn_dep_save_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                dep.Name = dep_name.Text;
                db.Entry(dep).State = EntityState.Added;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data added");
                dep_name.Text = "";

            }
            catch
            {
                MessageBox.Show("can not add data");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                dep_name.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

            }
            catch
            {

            }
        }

        private void btn_dep_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db = new TCCEntities();
                dep = new Department();
                dep.id = id;
                dep.Name = dep_name.Text;
                db.Entry(dep).State = EntityState.Modified;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data edited");
                dep_name.Text = "";

            }
            catch
            {
                MessageBox.Show("can not edit data");
            }
        }

        private void btn_dep_delete_Click(object sender, EventArgs e)
        {
            try
            {
                db = new TCCEntities();
                dep = new Department();
                dep.id = id;
                
                db.Entry(dep).State = EntityState.Deleted;
                db.SaveChanges();
                LoadData();
                MessageBox.Show("data deleted");
                dep_name.Text = "";

            }
            catch
            {
                MessageBox.Show("can not delete data");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
