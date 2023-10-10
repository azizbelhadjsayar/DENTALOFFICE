namespace DS1
{
    partial class nouveau_mdp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nouveau_mdp));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.iconEXIT = new System.Windows.Forms.PictureBox();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.iconBACK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // iconEXIT
            // 
            this.iconEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconEXIT.Image = global::DS1.Properties.Resources._3;
            this.iconEXIT.Location = new System.Drawing.Point(232, 344);
            this.iconEXIT.Name = "iconEXIT";
            this.iconEXIT.Size = new System.Drawing.Size(72, 72);
            this.iconEXIT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconEXIT.TabIndex = 18;
            this.iconEXIT.TabStop = false;
            this.iconEXIT.Click += new System.EventHandler(this.iconEXIT_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 25;
            this.guna2Elipse3.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(16, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 426);
            this.panel1.TabIndex = 21;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Animated = true;
            this.btnConfirmer.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmer.BorderRadius = 20;
            this.btnConfirmer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmer.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.ForeColor = System.Drawing.Color.White;
            this.btnConfirmer.Location = new System.Drawing.Point(152, 232);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(264, 56);
            this.btnConfirmer.TabIndex = 20;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DS1.Properties.Resources._5;
            this.pictureBox3.Location = new System.Drawing.Point(424, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(128, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nouveau mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNouveau
            // 
            this.txtNouveau.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouveau.Location = new System.Drawing.Point(128, 160);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(312, 34);
            this.txtNouveau.TabIndex = 16;
            this.txtNouveau.TextChanged += new System.EventHandler(this.txtNouveau_TextChanged);
            // 
            // iconBACK
            // 
            this.iconBACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBACK.Image = global::DS1.Properties.Resources._4;
            this.iconBACK.Location = new System.Drawing.Point(96, 24);
            this.iconBACK.Name = "iconBACK";
            this.iconBACK.Size = new System.Drawing.Size(80, 56);
            this.iconBACK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBACK.TabIndex = 22;
            this.iconBACK.TabStop = false;
            this.iconBACK.Click += new System.EventHandler(this.iconBACK_Click);
            // 
            // nouveau_mdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 452);
            this.Controls.Add(this.iconBACK);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconEXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nouveau_mdp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nouveau_mdp";
            ((System.ComponentModel.ISupportInitialize)(this.iconEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBACK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnConfirmer;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconEXIT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox iconBACK;
    }
}