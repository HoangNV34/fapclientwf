namespace FapClient.GUI
{
    partial class EditForm
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
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTeachDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSlot = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.rbPresent = new System.Windows.Forms.RadioButton();
            this.rbAbsent = new System.Windows.Forms.RadioButton();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStudentName
            // 
            this.tbStudentName.Enabled = false;
            this.tbStudentName.Location = new System.Drawing.Point(135, 9);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(152, 23);
            this.tbStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teaching Date";
            // 
            // dtpTeachDate
            // 
            this.dtpTeachDate.Location = new System.Drawing.Point(135, 51);
            this.dtpTeachDate.Name = "dtpTeachDate";
            this.dtpTeachDate.Size = new System.Drawing.Size(200, 23);
            this.dtpTeachDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Slot";
            // 
            // cbbSlot
            // 
            this.cbbSlot.DisplayMember = "1,2,3,4,5,6,7,8";
            this.cbbSlot.FormattingEnabled = true;
            this.cbbSlot.Location = new System.Drawing.Point(135, 86);
            this.cbbSlot.Name = "cbbSlot";
            this.cbbSlot.Size = new System.Drawing.Size(121, 23);
            this.cbbSlot.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Attedance Status";
            // 
            // rtbComment
            // 
            this.rtbComment.Location = new System.Drawing.Point(135, 201);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(234, 147);
            this.rtbComment.TabIndex = 10;
            this.rtbComment.Text = "";
            // 
            // rbPresent
            // 
            this.rbPresent.AutoSize = true;
            this.rbPresent.Location = new System.Drawing.Point(192, 163);
            this.rbPresent.Name = "rbPresent";
            this.rbPresent.Size = new System.Drawing.Size(64, 19);
            this.rbPresent.TabIndex = 11;
            this.rbPresent.TabStop = true;
            this.rbPresent.Text = "Present";
            this.rbPresent.UseVisualStyleBackColor = true;
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.Location = new System.Drawing.Point(271, 163);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(62, 19);
            this.rbAbsent.TabIndex = 12;
            this.rbAbsent.TabStop = true;
            this.rbAbsent.Text = "Absent";
            this.rbAbsent.UseVisualStyleBackColor = true;
            // 
            // cbbRoom
            // 
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(135, 124);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(121, 23);
            this.cbbRoom.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Room";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(201, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(294, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 403);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbbRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbAbsent);
            this.Controls.Add(this.rbPresent);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbSlot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTeachDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStudentName);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTeachDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSlot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.RadioButton rbPresent;
        private System.Windows.Forms.RadioButton rbAbsent;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}