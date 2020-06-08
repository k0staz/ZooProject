namespace ZooProject
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserType = new System.Windows.Forms.ComboBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Telephon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PassportData = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Facility = new System.Windows.Forms.ComboBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация нового пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пожалуйста, заполните поля ниже";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(808, 10);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(179, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(179, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(179, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Тип пользователя";
            // 
            // UserType
            // 
            this.UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserType.FormattingEnabled = true;
            this.UserType.Location = new System.Drawing.Point(387, 163);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(157, 21);
            this.UserType.TabIndex = 12;
            this.UserType.SelectedIndexChanged += new System.EventHandler(this.UserType_SelectedIndexChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(387, 111);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(157, 20);
            this.Login.TabIndex = 13;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(387, 137);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(157, 20);
            this.Password.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(108, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Фамилия";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(182, 218);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(157, 20);
            this.LastName.TabIndex = 13;
            // 
            // Telephon
            // 
            this.Telephon.Location = new System.Drawing.Point(387, 190);
            this.Telephon.Name = "Telephon";
            this.Telephon.Size = new System.Drawing.Size(157, 20);
            this.Telephon.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(179, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Телефон";
            // 
            // PassportData
            // 
            this.PassportData.Location = new System.Drawing.Point(387, 242);
            this.PassportData.Name = "PassportData";
            this.PassportData.Size = new System.Drawing.Size(157, 20);
            this.PassportData.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(179, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Паспортные данные";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(179, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Здание работы";
            // 
            // Facility
            // 
            this.Facility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Facility.FormattingEnabled = true;
            this.Facility.Location = new System.Drawing.Point(387, 268);
            this.Facility.Name = "Facility";
            this.Facility.Size = new System.Drawing.Size(157, 21);
            this.Facility.TabIndex = 12;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationButton.Location = new System.Drawing.Point(387, 307);
            this.RegistrationButton.Margin = new System.Windows.Forms.Padding(15);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(157, 32);
            this.RegistrationButton.TabIndex = 14;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(-5, 357);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(808, 10);
            this.label11.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(671, 382);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 32);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(345, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Имя";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(387, 216);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(157, 20);
            this.FirstName.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(550, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 11;
            this.label13.Text = "Отчество";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(631, 218);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(157, 20);
            this.SecondName.TabIndex = 13;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.PassportData);
            this.Controls.Add(this.Telephon);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Facility);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Telephon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PassportData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Facility;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SecondName;
    }
}