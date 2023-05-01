
namespace entity_framwork_program
{
    partial class frm_department
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dep_name = new System.Windows.Forms.TextBox();
            this.btn_dep_save = new System.Windows.Forms.Button();
            this.btn_dep_edit = new System.Windows.Forms.Button();
            this.btn_dep_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_dep_delete);
            this.panel1.Controls.Add(this.btn_dep_edit);
            this.panel1.Controls.Add(this.btn_dep_save);
            this.panel1.Controls.Add(this.dep_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 103);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dep_name
            // 
            this.dep_name.Location = new System.Drawing.Point(127, 42);
            this.dep_name.Name = "dep_name";
            this.dep_name.Size = new System.Drawing.Size(170, 24);
            this.dep_name.TabIndex = 1;
            // 
            // btn_dep_save
            // 
            this.btn_dep_save.Location = new System.Drawing.Point(356, 43);
            this.btn_dep_save.Name = "btn_dep_save";
            this.btn_dep_save.Size = new System.Drawing.Size(75, 23);
            this.btn_dep_save.TabIndex = 2;
            this.btn_dep_save.Text = "save";
            this.btn_dep_save.UseVisualStyleBackColor = true;
            this.btn_dep_save.Click += new System.EventHandler(this.btn_dep_save_Click);
            // 
            // btn_dep_edit
            // 
            this.btn_dep_edit.Location = new System.Drawing.Point(437, 43);
            this.btn_dep_edit.Name = "btn_dep_edit";
            this.btn_dep_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_dep_edit.TabIndex = 2;
            this.btn_dep_edit.Text = "edit";
            this.btn_dep_edit.UseVisualStyleBackColor = true;
            this.btn_dep_edit.Click += new System.EventHandler(this.btn_dep_edit_Click);
            // 
            // btn_dep_delete
            // 
            this.btn_dep_delete.Location = new System.Drawing.Point(518, 43);
            this.btn_dep_delete.Name = "btn_dep_delete";
            this.btn_dep_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_dep_delete.TabIndex = 2;
            this.btn_dep_delete.Text = "delete";
            this.btn_dep_delete.UseVisualStyleBackColor = true;
            this.btn_dep_delete.Click += new System.EventHandler(this.btn_dep_delete_Click);
            // 
            // frm_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_department";
            this.Text = "frm_department";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dep_delete;
        private System.Windows.Forms.Button btn_dep_edit;
        private System.Windows.Forms.Button btn_dep_save;
        private System.Windows.Forms.TextBox dep_name;
        private System.Windows.Forms.Label label1;
    }
}