namespace ZooProject
{
    partial class Tickets
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkWorld = new System.Windows.Forms.CheckBox();
            this.checkSky = new System.Windows.Forms.CheckBox();
            this.checkOcean = new System.Windows.Forms.CheckBox();
            this.checkEarth = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EarthLabel = new System.Windows.Forms.Label();
            this.CrossLabel = new System.Windows.Forms.Label();
            this.OceanLabel = new System.Windows.Forms.Label();
            this.SkyLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.FinalSumm = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.numericMature = new System.Windows.Forms.NumericUpDown();
            this.numericChildren = new System.Windows.Forms.NumericUpDown();
            this.Export_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericMature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(216)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(816, 10);
            this.label3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Заполните данные, необходимые для покупки биллета, ниже";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Билеты";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(81)))), ((int)(((byte)(216)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(-11, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(816, 10);
            this.label4.TabIndex = 25;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(683, 413);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 32);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(573, 92);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 6, 17, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // checkWorld
            // 
            this.checkWorld.AutoSize = true;
            this.checkWorld.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkWorld.Location = new System.Drawing.Point(394, 90);
            this.checkWorld.Name = "checkWorld";
            this.checkWorld.Size = new System.Drawing.Size(105, 22);
            this.checkWorld.TabIndex = 32;
            this.checkWorld.Text = "Cross World";
            this.checkWorld.UseVisualStyleBackColor = true;
            this.checkWorld.CheckStateChanged += new System.EventHandler(this.checkWorld_CheckStateChanged);
            // 
            // checkSky
            // 
            this.checkSky.AutoSize = true;
            this.checkSky.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSky.Location = new System.Drawing.Point(296, 90);
            this.checkSky.Name = "checkSky";
            this.checkSky.Size = new System.Drawing.Size(92, 22);
            this.checkSky.TabIndex = 33;
            this.checkSky.Text = "Sky World";
            this.checkSky.UseVisualStyleBackColor = true;
            this.checkSky.CheckStateChanged += new System.EventHandler(this.checkSky_CheckStateChanged);
            // 
            // checkOcean
            // 
            this.checkOcean.AutoSize = true;
            this.checkOcean.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkOcean.Location = new System.Drawing.Point(180, 90);
            this.checkOcean.Name = "checkOcean";
            this.checkOcean.Size = new System.Drawing.Size(111, 22);
            this.checkOcean.TabIndex = 34;
            this.checkOcean.Text = "Ocean World";
            this.checkOcean.UseVisualStyleBackColor = true;
            this.checkOcean.CheckStateChanged += new System.EventHandler(this.checkOcean_CheckStateChanged);
            // 
            // checkEarth
            // 
            this.checkEarth.AutoSize = true;
            this.checkEarth.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkEarth.Location = new System.Drawing.Point(71, 90);
            this.checkEarth.Name = "checkEarth";
            this.checkEarth.Size = new System.Drawing.Size(103, 22);
            this.checkEarth.TabIndex = 35;
            this.checkEarth.Text = "Earth World";
            this.checkEarth.UseVisualStyleBackColor = true;
            this.checkEarth.CheckStateChanged += new System.EventHandler(this.checkEarth_CheckStateChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Количество билетов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(520, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Дата:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Корпус:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "для взрослых:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(2, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "для детей:";
            // 
            // EarthLabel
            // 
            this.EarthLabel.AutoSize = true;
            this.EarthLabel.BackColor = System.Drawing.Color.Transparent;
            this.EarthLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EarthLabel.Location = new System.Drawing.Point(542, 151);
            this.EarthLabel.Name = "EarthLabel";
            this.EarthLabel.Size = new System.Drawing.Size(64, 18);
            this.EarthLabel.TabIndex = 29;
            this.EarthLabel.Text = "Choosed";
            this.EarthLabel.Visible = false;
            // 
            // CrossLabel
            // 
            this.CrossLabel.AutoSize = true;
            this.CrossLabel.BackColor = System.Drawing.Color.Transparent;
            this.CrossLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossLabel.Location = new System.Drawing.Point(414, 231);
            this.CrossLabel.Name = "CrossLabel";
            this.CrossLabel.Size = new System.Drawing.Size(64, 18);
            this.CrossLabel.TabIndex = 29;
            this.CrossLabel.Text = "Choosed";
            this.CrossLabel.Visible = false;
            // 
            // OceanLabel
            // 
            this.OceanLabel.AutoSize = true;
            this.OceanLabel.BackColor = System.Drawing.Color.Transparent;
            this.OceanLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OceanLabel.Location = new System.Drawing.Point(689, 321);
            this.OceanLabel.Name = "OceanLabel";
            this.OceanLabel.Size = new System.Drawing.Size(64, 18);
            this.OceanLabel.TabIndex = 29;
            this.OceanLabel.Text = "Choosed";
            this.OceanLabel.Visible = false;
            // 
            // SkyLabel
            // 
            this.SkyLabel.AutoSize = true;
            this.SkyLabel.BackColor = System.Drawing.Color.Transparent;
            this.SkyLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkyLabel.Location = new System.Drawing.Point(680, 186);
            this.SkyLabel.Name = "SkyLabel";
            this.SkyLabel.Size = new System.Drawing.Size(64, 18);
            this.SkyLabel.TabIndex = 29;
            this.SkyLabel.Text = "Choosed";
            this.SkyLabel.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(2, 370);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 18);
            this.label14.TabIndex = 29;
            this.label14.Text = "Общая цена:";
            // 
            // FinalSumm
            // 
            this.FinalSumm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinalSumm.Location = new System.Drawing.Point(107, 370);
            this.FinalSumm.Name = "FinalSumm";
            this.FinalSumm.Size = new System.Drawing.Size(45, 18);
            this.FinalSumm.TabIndex = 29;
            this.FinalSumm.Click += new System.EventHandler(this.FinalSumm_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.Location = new System.Drawing.Point(157, 363);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(15);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(105, 32);
            this.buttonBuy.TabIndex = 27;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // numericMature
            // 
            this.numericMature.Location = new System.Drawing.Point(115, 148);
            this.numericMature.Name = "numericMature";
            this.numericMature.Size = new System.Drawing.Size(30, 20);
            this.numericMature.TabIndex = 40;
            this.numericMature.ValueChanged += new System.EventHandler(this.Value_changed);
            // 
            // numericChildren
            // 
            this.numericChildren.Location = new System.Drawing.Point(115, 179);
            this.numericChildren.Name = "numericChildren";
            this.numericChildren.Size = new System.Drawing.Size(30, 20);
            this.numericChildren.TabIndex = 40;
            this.numericChildren.ValueChanged += new System.EventHandler(this.Value_changed);
            // 
            // Export_button
            // 
            this.Export_button.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Export_button.Location = new System.Drawing.Point(6, 413);
            this.Export_button.Margin = new System.Windows.Forms.Padding(15);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(146, 32);
            this.Export_button.TabIndex = 27;
            this.Export_button.Text = "Выгрузка данных";
            this.Export_button.UseVisualStyleBackColor = true;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZooProject.Properties.Resources.Bez_imeni_1;
            this.pictureBox1.Location = new System.Drawing.Point(394, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericChildren);
            this.Controls.Add(this.numericMature);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkWorld);
            this.Controls.Add(this.checkSky);
            this.Controls.Add(this.checkOcean);
            this.Controls.Add(this.checkEarth);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SkyLabel);
            this.Controls.Add(this.OceanLabel);
            this.Controls.Add(this.CrossLabel);
            this.Controls.Add(this.EarthLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FinalSumm);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Export_button);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tickets";
            this.Text = "Tickets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tickets_FormClosed);
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericMature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkWorld;
        private System.Windows.Forms.CheckBox checkSky;
        private System.Windows.Forms.CheckBox checkOcean;
        private System.Windows.Forms.CheckBox checkEarth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EarthLabel;
        private System.Windows.Forms.Label CrossLabel;
        private System.Windows.Forms.Label OceanLabel;
        private System.Windows.Forms.Label SkyLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label FinalSumm;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.NumericUpDown numericMature;
        private System.Windows.Forms.NumericUpDown numericChildren;
        private System.Windows.Forms.Button Export_button;
    }
}