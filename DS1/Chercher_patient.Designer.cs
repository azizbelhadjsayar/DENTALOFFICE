namespace DS1
{
    partial class Chercher_patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chercher_patient));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconMENU = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconEXIT = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listViewPatients = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconBACK = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(296, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selectionner la date de naissance :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDate
            // 
            this.dtpDate.AutoRoundedCorners = true;
            this.dtpDate.BorderRadius = 17;
            this.dtpDate.Checked = true;
            this.dtpDate.FillColor = System.Drawing.SystemColors.ControlLight;
            this.dtpDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(424, 96);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(232, 36);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDate.Value = new System.DateTime(2023, 4, 14, 14, 44, 31, 709);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.iconMENU);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.iconEXIT);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 520);
            this.panel1.TabIndex = 11;
            // 
            // iconMENU
            // 
            this.iconMENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMENU.Image = global::DS1.Properties.Resources._12;
            this.iconMENU.Location = new System.Drawing.Point(16, 32);
            this.iconMENU.Name = "iconMENU";
            this.iconMENU.Size = new System.Drawing.Size(56, 48);
            this.iconMENU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMENU.TabIndex = 23;
            this.iconMENU.TabStop = false;
            this.iconMENU.Click += new System.EventHandler(this.iconMENU_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "MENU";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconEXIT
            // 
            this.iconEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEXIT.Image = global::DS1.Properties.Resources._3;
            this.iconEXIT.Location = new System.Drawing.Point(16, 456);
            this.iconEXIT.Name = "iconEXIT";
            this.iconEXIT.Size = new System.Drawing.Size(56, 48);
            this.iconEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEXIT.TabIndex = 6;
            this.iconEXIT.TabStop = false;
            this.iconEXIT.Click += new System.EventHandler(this.iconEXIT_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this;
            // 
            // listViewPatients
            // 
            this.listViewPatients.BackColor = System.Drawing.SystemColors.Info;
            this.listViewPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prénom,
            this.DateNaissance,
            this.NUM,
            this.mail});
            this.listViewPatients.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPatients.ForeColor = System.Drawing.Color.Black;
            this.listViewPatients.FullRowSelect = true;
            this.listViewPatients.GridLines = true;
            this.listViewPatients.HideSelection = false;
            this.listViewPatients.Location = new System.Drawing.Point(136, 152);
            this.listViewPatients.Margin = new System.Windows.Forms.Padding(25, 0, 25, 40);
            this.listViewPatients.MultiSelect = false;
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(817, 360);
            this.listViewPatients.TabIndex = 12;
            this.listViewPatients.UseCompatibleStateImageBehavior = false;
            this.listViewPatients.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 100;
            // 
            // Prénom
            // 
            this.Prénom.Text = "Prénom";
            this.Prénom.Width = 80;
            // 
            // DateNaissance
            // 
            this.DateNaissance.Text = "Date de naissance";
            this.DateNaissance.Width = 120;
            // 
            // NUM
            // 
            this.NUM.Text = "Numéro de téléphone";
            this.NUM.Width = 140;
            // 
            // mail
            // 
            this.mail.Text = "Adresse e-mail";
            this.mail.Width = 170;
            // 
            // iconBACK
            // 
            this.iconBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBACK.Image = global::DS1.Properties.Resources._4;
            this.iconBACK.Location = new System.Drawing.Point(120, 24);
            this.iconBACK.Name = "iconBACK";
            this.iconBACK.Size = new System.Drawing.Size(104, 80);
            this.iconBACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBACK.TabIndex = 13;
            this.iconBACK.TabStop = false;
            this.iconBACK.Click += new System.EventHandler(this.iconBACK_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DS1.Properties.Resources._5;
            this.pictureBox3.Location = new System.Drawing.Point(920, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Chercher_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 551);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.iconBACK);
            this.Controls.Add(this.listViewPatients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chercher_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chercher_patient";
            this.Load += new System.EventHandler(this.Chercher_patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconMENU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox iconEXIT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.ListView listViewPatients;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader DateNaissance;
        private System.Windows.Forms.ColumnHeader NUM;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.PictureBox iconBACK;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}