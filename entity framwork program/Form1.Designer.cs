
namespace entity_framwork_program
{
    partial class Form1
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
            this.btn_dep = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_subject = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_subjectlecture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dep
            // 
            this.btn_dep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dep.Location = new System.Drawing.Point(518, 103);
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.Size = new System.Drawing.Size(156, 64);
            this.btn_dep.TabIndex = 0;
            this.btn_dep.Text = "Department";
            this.btn_dep.UseVisualStyleBackColor = true;
            this.btn_dep.Click += new System.EventHandler(this.btn_dep_Click);
            // 
            // btn_student
            // 
            this.btn_student.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_student.Location = new System.Drawing.Point(327, 103);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(156, 64);
            this.btn_student.TabIndex = 1;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            this.btn_student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_subject
            // 
            this.btn_subject.Location = new System.Drawing.Point(117, 103);
            this.btn_subject.Name = "btn_subject";
            this.btn_subject.Size = new System.Drawing.Size(156, 64);
            this.btn_subject.TabIndex = 1;
            this.btn_subject.Text = "subject";
            this.btn_subject.UseVisualStyleBackColor = true;
            this.btn_subject.Click += new System.EventHandler(this.btn_subject_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(117, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 64);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(327, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 64);
            this.button4.TabIndex = 1;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_subjectlecture
            // 
            this.btn_subjectlecture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_subjectlecture.Location = new System.Drawing.Point(518, 232);
            this.btn_subjectlecture.Name = "btn_subjectlecture";
            this.btn_subjectlecture.Size = new System.Drawing.Size(156, 64);
            this.btn_subjectlecture.TabIndex = 1;
            this.btn_subjectlecture.Text = "subjectlecture";
            this.btn_subjectlecture.UseVisualStyleBackColor = true;
            this.btn_subjectlecture.Click += new System.EventHandler(this.btn_subjectlecture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_subjectlecture);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_subject);
            this.Controls.Add(this.btn_student);
            this.Controls.Add(this.btn_dep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dep;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_subject;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_subjectlecture;
    }
}

