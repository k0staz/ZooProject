namespace ZooProject
{
    partial class animal_create
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Species = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Family = new System.Windows.Forms.TextBox();
            this.Food = new System.Windows.Forms.TrackBar();
            this.Food_label = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.Facility = new System.Windows.Forms.ComboBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(144, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Название животного";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Семейство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(144, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Потребляемое еды/день";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(144, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ареал обитания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(144, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Корпус";
            // 
            // Species
            // 
            this.Species.Location = new System.Drawing.Point(349, 137);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(197, 20);
            this.Species.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(-4, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(808, 10);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(294, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Пожалуйста, заполните поля ниже";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(177, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(461, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Добавление нового животного";
            // 
            // Family
            // 
            this.Family.Location = new System.Drawing.Point(349, 163);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(197, 20);
            this.Family.TabIndex = 13;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(349, 189);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(197, 45);
            this.Food.TabIndex = 17;
            this.Food.TickFrequency = 5;
            this.Food.ValueChanged += new System.EventHandler(this.Food_ValueChanged);
            // 
            // Food_label
            // 
            this.Food_label.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Food_label.Location = new System.Drawing.Point(552, 189);
            this.Food_label.Name = "Food_label";
            this.Food_label.Size = new System.Drawing.Size(54, 41);
            this.Food_label.TabIndex = 12;
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(349, 240);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(197, 20);
            this.Location.TabIndex = 13;
            // 
            // Facility
            // 
            this.Facility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Facility.FormattingEnabled = true;
            this.Facility.Location = new System.Drawing.Point(349, 266);
            this.Facility.Name = "Facility";
            this.Facility.Size = new System.Drawing.Size(197, 21);
            this.Facility.TabIndex = 18;
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_button.Location = new System.Drawing.Point(349, 305);
            this.Add_button.Margin = new System.Windows.Forms.Padding(15);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(197, 32);
            this.Add_button.TabIndex = 19;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(-4, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(808, 10);
            this.label9.TabIndex = 16;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(671, 377);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 32);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // animal_create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Facility);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.Species);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Food_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "animal_create";
            this.Text = "animal_create";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.animal_create_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Species;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Family;
        private System.Windows.Forms.TrackBar Food;
        private System.Windows.Forms.Label Food_label;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.ComboBox Facility;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CancelButton;
    }
}