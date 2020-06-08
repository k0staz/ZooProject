namespace ZooProject
{
    partial class excursion
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
            this.Facility = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.ComboBox();
            this.exc_date = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Facility
            // 
            this.Facility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Facility.FormattingEnabled = true;
            this.Facility.Location = new System.Drawing.Point(145, 103);
            this.Facility.Name = "Facility";
            this.Facility.Size = new System.Drawing.Size(157, 21);
            this.Facility.TabIndex = 19;
            this.Facility.SelectedValueChanged += new System.EventHandler(this.Facility_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Корпус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Экскурсии";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Все доступные экскурсии представлены ниже";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(0)))), ((int)(((byte)(119)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-4, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 10);
            this.label3.TabIndex = 22;
            // 
            // Employee
            // 
            this.Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Employee.FormattingEnabled = true;
            this.Employee.Location = new System.Drawing.Point(145, 151);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(157, 21);
            this.Employee.TabIndex = 19;
            this.Employee.SelectedValueChanged += new System.EventHandler(this.Employee_SelectedValueChanged);
            // 
            // exc_date
            // 
            this.exc_date.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exc_date.FormattingEnabled = true;
            this.exc_date.Location = new System.Drawing.Point(145, 201);
            this.exc_date.Name = "exc_date";
            this.exc_date.Size = new System.Drawing.Size(157, 21);
            this.exc_date.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Экскурсовод";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дата";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(330, 295);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 32);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.Location = new System.Drawing.Point(113, 295);
            this.Registration.Margin = new System.Windows.Forms.Padding(15);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(105, 32);
            this.Registration.TabIndex = 23;
            this.Registration.Text = "Записаться";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // excursion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 339);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exc_date);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Facility);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "excursion";
            this.Text = "excursion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.excursion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Facility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Employee;
        private System.Windows.Forms.ComboBox exc_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button Registration;
    }
}