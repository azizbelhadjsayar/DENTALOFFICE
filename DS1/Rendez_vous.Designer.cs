namespace DS1
{
    partial class Rendez_vous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rendez_vous));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listBoxRV = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSupprimer = new Guna.UI2.WinForms.Guna2Button();
            this.iconEXIT = new System.Windows.Forms.PictureBox();
            this.iconMENU = new System.Windows.Forms.PictureBox();
            this.iconAJOUTER_RV = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAJOUTER_RV)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // listBoxRV
            // 
            this.listBoxRV.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRV.FormattingEnabled = true;
            this.listBoxRV.ItemHeight = 20;
            this.listBoxRV.Location = new System.Drawing.Point(56, 136);
            this.listBoxRV.Name = "listBoxRV";
            this.listBoxRV.Size = new System.Drawing.Size(536, 464);
            this.listBoxRV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(21, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 104);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liste des rendez-vous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 20;
            this.guna2Elipse3.TargetControl = this.listBoxRV;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Animated = true;
            this.btnSupprimer.AnimatedGIF = true;
            this.btnSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btnSupprimer.BorderRadius = 10;
            this.btnSupprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupprimer.FillColor = System.Drawing.Color.SlateGray;
            this.btnSupprimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(56, 608);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(160, 32);
            this.btnSupprimer.TabIndex = 28;
            this.btnSupprimer.Text = "Supprimer tout";
            this.btnSupprimer.UseTransparentBackground = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // iconEXIT
            // 
            this.iconEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEXIT.Image = global::DS1.Properties.Resources._3;
            this.iconEXIT.Location = new System.Drawing.Point(576, 792);
            this.iconEXIT.Name = "iconEXIT";
            this.iconEXIT.Size = new System.Drawing.Size(56, 48);
            this.iconEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEXIT.TabIndex = 27;
            this.iconEXIT.TabStop = false;
            this.iconEXIT.Click += new System.EventHandler(this.iconEXIT_Click);
            // 
            // iconMENU
            // 
            this.iconMENU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMENU.Image = global::DS1.Properties.Resources._12;
            this.iconMENU.Location = new System.Drawing.Point(24, 792);
            this.iconMENU.Name = "iconMENU";
            this.iconMENU.Size = new System.Drawing.Size(56, 48);
            this.iconMENU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMENU.TabIndex = 26;
            this.iconMENU.TabStop = false;
            this.iconMENU.Click += new System.EventHandler(this.iconMENU_Click);
            // 
            // iconAJOUTER_RV
            // 
            this.iconAJOUTER_RV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconAJOUTER_RV.Image = global::DS1.Properties.Resources._14;
            this.iconAJOUTER_RV.Location = new System.Drawing.Point(264, 656);
            this.iconAJOUTER_RV.Name = "iconAJOUTER_RV";
            this.iconAJOUTER_RV.Size = new System.Drawing.Size(136, 128);
            this.iconAJOUTER_RV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconAJOUTER_RV.TabIndex = 11;
            this.iconAJOUTER_RV.TabStop = false;
            this.iconAJOUTER_RV.Click += new System.EventHandler(this.iconAJOUTER_RV_Click);
            // 
            // Rendez_vous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 864);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.iconEXIT);
            this.Controls.Add(this.iconMENU);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconAJOUTER_RV);
            this.Controls.Add(this.listBoxRV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rendez_vous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendez_vous";
            this.Load += new System.EventHandler(this.Rendez_vous_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMENU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAJOUTER_RV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ListBox listBoxRV;
        private System.Windows.Forms.PictureBox iconAJOUTER_RV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox iconEXIT;
        private System.Windows.Forms.PictureBox iconMENU;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Button btnSupprimer;
    }
}