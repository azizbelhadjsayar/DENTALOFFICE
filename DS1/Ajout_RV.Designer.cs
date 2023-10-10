namespace DS1
{
    partial class Ajout_RV
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mtxtNum = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxheure = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboxAMPM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconEXIT = new System.Windows.Forms.PictureBox();
            this.iconMENU = new System.Windows.Forms.PictureBox();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.iconBACK = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 104);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nouveau rendez-vous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // mtxtNum
            // 
            this.mtxtNum.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.mtxtNum.Location = new System.Drawing.Point(48, 456);
            this.mtxtNum.Mask = "(+216)99 999 999";
            this.mtxtNum.Name = "mtxtNum";
            this.mtxtNum.Size = new System.Drawing.Size(200, 34);
            this.mtxtNum.TabIndex = 21;
            this.mtxtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtNum.Leave += new System.EventHandler(this.mtxtNum_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(56, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "N° de téléphone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.txtPrenom.Location = new System.Drawing.Point(408, 344);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(177, 34);
            this.txtPrenom.TabIndex = 20;
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(56, 344);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(177, 34);
            this.txtNom.TabIndex = 19;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(440, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prénom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(104, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(440, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.AutoRoundedCorners = true;
            this.dtpDate.BorderRadius = 17;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDate.Font = new System.Drawing.Font("Calibri", 13.2F);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(360, 456);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(240, 36);
            this.dtpDate.TabIndex = 26;
            this.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDate.Value = new System.DateTime(2023, 4, 14, 14, 44, 31, 709);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(272, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Heure";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxheure
            // 
            this.cboxheure.BackColor = System.Drawing.Color.Transparent;
            this.cboxheure.BorderRadius = 10;
            this.cboxheure.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxheure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxheure.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxheure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxheure.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxheure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxheure.ItemHeight = 30;
            this.cboxheure.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboxheure.Location = new System.Drawing.Point(216, 560);
            this.cboxheure.Name = "cboxheure";
            this.cboxheure.Size = new System.Drawing.Size(96, 36);
            this.cboxheure.TabIndex = 28;
            // 
            // cboxAMPM
            // 
            this.cboxAMPM.BackColor = System.Drawing.Color.Transparent;
            this.cboxAMPM.BorderRadius = 10;
            this.cboxAMPM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAMPM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxAMPM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxAMPM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.cboxAMPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxAMPM.ItemHeight = 30;
            this.cboxAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cboxAMPM.Location = new System.Drawing.Point(320, 560);
            this.cboxAMPM.Name = "cboxAMPM";
            this.cboxAMPM.Size = new System.Drawing.Size(96, 36);
            this.cboxAMPM.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::DS1.Properties.Resources._15;
            this.pictureBox1.Location = new System.Drawing.Point(272, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // iconEXIT
            // 
            this.iconEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEXIT.Image = global::DS1.Properties.Resources._3;
            this.iconEXIT.Location = new System.Drawing.Point(567, 704);
            this.iconEXIT.Name = "iconEXIT";
            this.iconEXIT.Size = new System.Drawing.Size(56, 48);
            this.iconEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEXIT.TabIndex = 33;
            this.iconEXIT.TabStop = false;
            this.iconEXIT.Click += new System.EventHandler(this.iconEXIT_Click);
            // 
            // iconMENU
            // 
            this.iconMENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMENU.Image = global::DS1.Properties.Resources._12;
            this.iconMENU.Location = new System.Drawing.Point(23, 704);
            this.iconMENU.Name = "iconMENU";
            this.iconMENU.Size = new System.Drawing.Size(56, 48);
            this.iconMENU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMENU.TabIndex = 32;
            this.iconMENU.TabStop = false;
            this.iconMENU.Click += new System.EventHandler(this.iconMENU_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Animated = true;
            this.btnAjouter.AnimatedGIF = true;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BorderRadius = 20;
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAjouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(232, 624);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(184, 64);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseTransparentBackground = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // iconBACK
            // 
            this.iconBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBACK.Image = global::DS1.Properties.Resources._4;
            this.iconBACK.Location = new System.Drawing.Point(24, 136);
            this.iconBACK.Name = "iconBACK";
            this.iconBACK.Size = new System.Drawing.Size(80, 56);
            this.iconBACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBACK.TabIndex = 34;
            this.iconBACK.TabStop = false;
            this.iconBACK.Click += new System.EventHandler(this.iconBACK_Click);
            // 
            // Ajout_RV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 770);
            this.Controls.Add(this.iconBACK);
            this.Controls.Add(this.iconEXIT);
            this.Controls.Add(this.iconMENU);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxAMPM);
            this.Controls.Add(this.cboxheure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajout_RV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout_RV";
            this.Load += new System.EventHandler(this.Ajout_RV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboxAMPM;
        private Guna.UI2.WinForms.Guna2ComboBox cboxheure;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconEXIT;
        private System.Windows.Forms.PictureBox iconMENU;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private System.Windows.Forms.PictureBox iconBACK;
    }
}