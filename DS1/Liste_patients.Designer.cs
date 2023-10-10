namespace DS1
{
    partial class Liste_patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liste_patients));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listViewPatients = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2Button();
            this.btnChercher = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectionner = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconBACK = new System.Windows.Forms.PictureBox();
            this.iconRefresh = new System.Windows.Forms.PictureBox();
            this.iconMENU = new System.Windows.Forms.PictureBox();
            this.iconSUPPRIMER = new System.Windows.Forms.PictureBox();
            this.iconEXIT = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSUPPRIMER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).BeginInit();
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
            this.panel1.Controls.Add(this.iconMENU);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconSUPPRIMER);
            this.panel1.Controls.Add(this.iconEXIT);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 592);
            this.panel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Supprimer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // listViewPatients
            // 
            this.listViewPatients.BackColor = System.Drawing.SystemColors.Info;
            this.listViewPatients.CheckBoxes = true;
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
            this.listViewPatients.Location = new System.Drawing.Point(136, 120);
            this.listViewPatients.Margin = new System.Windows.Forms.Padding(25, 0, 25, 40);
            this.listViewPatients.MultiSelect = false;
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(817, 256);
            this.listViewPatients.TabIndex = 7;
            this.listViewPatients.UseCompatibleStateImageBehavior = false;
            this.listViewPatients.View = System.Windows.Forms.View.Details;
            this.listViewPatients.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewPatients_ItemChecked);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(328, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "Liste des patients";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAjouter.Location = new System.Drawing.Point(184, 440);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(192, 64);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseTransparentBackground = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnChercher
            // 
            this.btnChercher.Animated = true;
            this.btnChercher.BackColor = System.Drawing.Color.Transparent;
            this.btnChercher.BorderRadius = 20;
            this.btnChercher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChercher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChercher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChercher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChercher.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnChercher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChercher.ForeColor = System.Drawing.Color.White;
            this.btnChercher.Location = new System.Drawing.Point(688, 440);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(192, 64);
            this.btnChercher.TabIndex = 15;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseTransparentBackground = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Animated = true;
            this.btnSelectionner.AnimatedGIF = true;
            this.btnSelectionner.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectionner.BorderRadius = 10;
            this.btnSelectionner.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectionner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectionner.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectionner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectionner.FillColor = System.Drawing.Color.SlateGray;
            this.btnSelectionner.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(136, 384);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(176, 32);
            this.btnSelectionner.TabIndex = 19;
            this.btnSelectionner.Text = "Sélectionner tout";
            this.btnSelectionner.UseTransparentBackground = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DS1.Properties.Resources._5;
            this.pictureBox3.Location = new System.Drawing.Point(920, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::DS1.Properties.Resources._7;
            this.pictureBox2.Location = new System.Drawing.Point(752, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::DS1.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(240, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // iconBACK
            // 
            this.iconBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBACK.Image = global::DS1.Properties.Resources._4;
            this.iconBACK.Location = new System.Drawing.Point(120, 24);
            this.iconBACK.Name = "iconBACK";
            this.iconBACK.Size = new System.Drawing.Size(104, 80);
            this.iconBACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBACK.TabIndex = 6;
            this.iconBACK.TabStop = false;
            this.iconBACK.Click += new System.EventHandler(this.iconBACK_Click);
            // 
            // iconRefresh
            // 
            this.iconRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRefresh.Image = global::DS1.Properties.Resources._1;
            this.iconRefresh.Location = new System.Drawing.Point(472, 464);
            this.iconRefresh.Name = "iconRefresh";
            this.iconRefresh.Size = new System.Drawing.Size(112, 104);
            this.iconRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRefresh.TabIndex = 5;
            this.iconRefresh.TabStop = false;
            this.iconRefresh.Click += new System.EventHandler(this.iconRefresh_Click);
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
            // iconSUPPRIMER
            // 
            this.iconSUPPRIMER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconSUPPRIMER.Image = global::DS1.Properties.Resources._8;
            this.iconSUPPRIMER.Location = new System.Drawing.Point(16, 208);
            this.iconSUPPRIMER.Name = "iconSUPPRIMER";
            this.iconSUPPRIMER.Size = new System.Drawing.Size(56, 48);
            this.iconSUPPRIMER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSUPPRIMER.TabIndex = 7;
            this.iconSUPPRIMER.TabStop = false;
            this.iconSUPPRIMER.Click += new System.EventHandler(this.iconSUPPRIMER_Click);
            // 
            // iconEXIT
            // 
            this.iconEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEXIT.Image = global::DS1.Properties.Resources._3;
            this.iconEXIT.Location = new System.Drawing.Point(16, 520);
            this.iconEXIT.Name = "iconEXIT";
            this.iconEXIT.Size = new System.Drawing.Size(56, 48);
            this.iconEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEXIT.TabIndex = 6;
            this.iconEXIT.TabStop = false;
            this.iconEXIT.Click += new System.EventHandler(this.iconEXIT_Click);
            // 
            // Liste_patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 619);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconBACK);
            this.Controls.Add(this.iconRefresh);
            this.Controls.Add(this.listViewPatients);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Liste_patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste_patients";
            this.Load += new System.EventHandler(this.Liste_patients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSUPPRIMER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListView listViewPatients;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader DateNaissance;
        private System.Windows.Forms.ColumnHeader NUM;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox iconBACK;
        private System.Windows.Forms.PictureBox iconEXIT;
        private System.Windows.Forms.PictureBox iconRefresh;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnChercher;
        private Guna.UI2.WinForms.Guna2Button btnAjouter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconSUPPRIMER;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox iconMENU;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnSelectionner;
    }
}