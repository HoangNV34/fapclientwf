namespace FapClient.GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCampus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTerm = new System.Windows.Forms.ComboBox();
            this.lboxCourse = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lboxStudent = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a campus/program, student, term, course ...";
            // 
            // cbbCampus
            // 
            this.cbbCampus.FormattingEnabled = true;
            this.cbbCampus.Location = new System.Drawing.Point(21, 83);
            this.cbbCampus.Name = "cbbCampus";
            this.cbbCampus.Size = new System.Drawing.Size(146, 23);
            this.cbbCampus.TabIndex = 1;
            this.cbbCampus.SelectedIndexChanged += new System.EventHandler(this.cbbCampus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campus/Program";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Term";
            // 
            // cbbTerm
            // 
            this.cbbTerm.FormattingEnabled = true;
            this.cbbTerm.Location = new System.Drawing.Point(21, 154);
            this.cbbTerm.Name = "cbbTerm";
            this.cbbTerm.Size = new System.Drawing.Size(146, 23);
            this.cbbTerm.TabIndex = 3;
            // 
            // lboxCourse
            // 
            this.lboxCourse.FormattingEnabled = true;
            this.lboxCourse.ItemHeight = 15;
            this.lboxCourse.Location = new System.Drawing.Point(549, 80);
            this.lboxCourse.Name = "lboxCourse";
            this.lboxCourse.Size = new System.Drawing.Size(520, 94);
            this.lboxCourse.TabIndex = 5;
            this.lboxCourse.SelectedIndexChanged += new System.EventHandler(this.lboxCourse_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(549, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Report";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 224);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(1049, 262);
            this.dgv.TabIndex = 8;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(241, 83);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.PlaceholderText = "Search student";
            this.txtStudent.Size = new System.Drawing.Size(241, 23);
            this.txtStudent.TabIndex = 9;
            this.txtStudent.TextChanged += new System.EventHandler(this.txtStudent_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(241, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student";
            // 
            // lboxStudent
            // 
            this.lboxStudent.FormattingEnabled = true;
            this.lboxStudent.ItemHeight = 15;
            this.lboxStudent.Location = new System.Drawing.Point(241, 112);
            this.lboxStudent.Name = "lboxStudent";
            this.lboxStudent.Size = new System.Drawing.Size(241, 94);
            this.lboxStudent.TabIndex = 11;
            this.lboxStudent.SelectedIndexChanged += new System.EventHandler(this.lboxStudent_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 499);
            this.Controls.Add(this.lboxStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lboxCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbTerm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCampus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCampus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTerm;
        private System.Windows.Forms.ListBox lboxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lboxStudent;
        private System.Windows.Forms.TextBox txtTemp;
    }
}
