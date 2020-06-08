namespace ZooProject
{
    partial class map
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.air = new System.Windows.Forms.Label();
            this.ocean = new System.Windows.Forms.Label();
            this.cross = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.earth = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(64)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(-3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(808, 10);
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(172, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Просто наведите курсор на корпус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Карта";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(10, 9);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(105, 32);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // air
            // 
            this.air.AutoEllipsis = true;
            this.air.BackColor = System.Drawing.Color.Transparent;
            this.air.Location = new System.Drawing.Point(448, 92);
            this.air.Name = "air";
            this.air.Size = new System.Drawing.Size(85, 154);
            this.air.TabIndex = 17;
            this.air.Click += new System.EventHandler(this.label4_Click);
            this.air.MouseLeave += new System.EventHandler(this.generall_MouseLeave);
            this.air.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generall_MouseMove);
            // 
            // ocean
            // 
            this.ocean.AutoEllipsis = true;
            this.ocean.BackColor = System.Drawing.Color.Transparent;
            this.ocean.Location = new System.Drawing.Point(482, 330);
            this.ocean.Name = "ocean";
            this.ocean.Size = new System.Drawing.Size(86, 201);
            this.ocean.TabIndex = 17;
            this.ocean.Click += new System.EventHandler(this.label4_Click);
            this.ocean.MouseLeave += new System.EventHandler(this.generall_MouseLeave);
            this.ocean.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generall_MouseMove);
            // 
            // cross
            // 
            this.cross.BackColor = System.Drawing.Color.Transparent;
            this.cross.Location = new System.Drawing.Point(34, 133);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(84, 290);
            this.cross.TabIndex = 17;
            this.cross.Click += new System.EventHandler(this.label4_Click);
            this.cross.MouseLeave += new System.EventHandler(this.generall_MouseLeave);
            this.cross.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generall_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cross);
            this.panel1.Controls.Add(this.ocean);
            this.panel1.Controls.Add(this.air);
            this.panel1.Controls.Add(this.earth);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 599);
            this.panel1.TabIndex = 18;
            // 
            // earth
            // 
            this.earth.BackColor = System.Drawing.Color.Transparent;
            this.earth.Location = new System.Drawing.Point(226, 62);
            this.earth.Name = "earth";
            this.earth.Size = new System.Drawing.Size(118, 62);
            this.earth.TabIndex = 17;
            this.earth.Click += new System.EventHandler(this.label4_Click);
            this.earth.MouseLeave += new System.EventHandler(this.generall_MouseLeave);
            this.earth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.generall_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZooProject.Properties.Resources.Bez_imeni_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "map";
            this.Text = "Карта зоопарка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.map_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label air;
        private System.Windows.Forms.Label ocean;
        private System.Windows.Forms.Label cross;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label earth;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}