﻿
namespace NcsCRUD
{
    partial class Update
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
            this.SubmitUpd = new System.Windows.Forms.Button();
            this.Branch_Id = new System.Windows.Forms.TextBox();
            this.Std_Branch = new System.Windows.Forms.TextBox();
            this.Std_Id = new System.Windows.Forms.TextBox();
            this.Std_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.try_login = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SubmitUpd
            // 
            this.SubmitUpd.Location = new System.Drawing.Point(168, 214);
            this.SubmitUpd.Name = "SubmitUpd";
            this.SubmitUpd.Size = new System.Drawing.Size(100, 23);
            this.SubmitUpd.TabIndex = 26;
            this.SubmitUpd.Text = "Update";
            this.SubmitUpd.UseVisualStyleBackColor = true;
            this.SubmitUpd.Click += new System.EventHandler(this.SubmitUpd_Click);
            // 
            // Branch_Id
            // 
            this.Branch_Id.Location = new System.Drawing.Point(168, 162);
            this.Branch_Id.Name = "Branch_Id";
            this.Branch_Id.Size = new System.Drawing.Size(100, 20);
            this.Branch_Id.TabIndex = 25;
            // 
            // Std_Branch
            // 
            this.Std_Branch.Location = new System.Drawing.Point(168, 122);
            this.Std_Branch.Name = "Std_Branch";
            this.Std_Branch.Size = new System.Drawing.Size(100, 20);
            this.Std_Branch.TabIndex = 24;
            // 
            // Std_Id
            // 
            this.Std_Id.Location = new System.Drawing.Point(168, 85);
            this.Std_Id.Name = "Std_Id";
            this.Std_Id.Size = new System.Drawing.Size(100, 20);
            this.Std_Id.TabIndex = 23;
            // 
            // Std_name
            // 
            this.Std_name.Location = new System.Drawing.Point(168, 48);
            this.Std_name.Name = "Std_name";
            this.Std_name.Size = new System.Drawing.Size(100, 20);
            this.Std_name.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Branch ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(34, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Student Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Student Name";
            // 
            // try_login
            // 
            this.try_login.AutoSize = true;
            this.try_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.try_login.Location = new System.Drawing.Point(34, 224);
            this.try_login.Name = "try_login";
            this.try_login.Size = new System.Drawing.Size(54, 15);
            this.try_login.TabIndex = 27;
            this.try_login.TabStop = true;
            this.try_login.Text = "TryLogin";
            this.try_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.try_login_LinkClicked);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 284);
            this.Controls.Add(this.try_login);
            this.Controls.Add(this.SubmitUpd);
            this.Controls.Add(this.Branch_Id);
            this.Controls.Add(this.Std_Branch);
            this.Controls.Add(this.Std_Id);
            this.Controls.Add(this.Std_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitUpd;
        private System.Windows.Forms.TextBox Branch_Id;
        private System.Windows.Forms.TextBox Std_Branch;
        private System.Windows.Forms.TextBox Std_Id;
        private System.Windows.Forms.TextBox Std_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel try_login;
    }
}