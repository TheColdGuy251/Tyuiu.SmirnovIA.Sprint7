namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    partial class FormAbout_SIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SIA));
            this.buttonOK_SIA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_SIA = new System.Windows.Forms.PictureBox();
            this.labelInfo_SIA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SIA
            // 
            this.buttonOK_SIA.Location = new System.Drawing.Point(466, 194);
            this.buttonOK_SIA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK_SIA.Name = "buttonOK_SIA";
            this.buttonOK_SIA.Size = new System.Drawing.Size(112, 32);
            this.buttonOK_SIA.TabIndex = 8;
            this.buttonOK_SIA.Text = "Ок";
            this.buttonOK_SIA.UseVisualStyleBackColor = true;
            this.buttonOK_SIA.Click += new System.EventHandler(this.buttonOK_SIA_Click);
            // 
            // pictureBoxAvatar_SIA
            // 
            this.pictureBoxAvatar_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SIA.BackgroundImage")));
            this.pictureBoxAvatar_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAvatar_SIA.InitialImage = null;
            this.pictureBoxAvatar_SIA.Location = new System.Drawing.Point(13, 8);
            this.pictureBoxAvatar_SIA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxAvatar_SIA.Name = "pictureBoxAvatar_SIA";
            this.pictureBoxAvatar_SIA.Size = new System.Drawing.Size(138, 176);
            this.pictureBoxAvatar_SIA.TabIndex = 7;
            this.pictureBoxAvatar_SIA.TabStop = false;
            this.pictureBoxAvatar_SIA.Click += new System.EventHandler(this.pictureBoxAvatar_SIA_Click);
            // 
            // labelInfo_SIA
            // 
            this.labelInfo_SIA.AutoSize = true;
            this.labelInfo_SIA.Location = new System.Drawing.Point(159, 9);
            this.labelInfo_SIA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_SIA.Name = "labelInfo_SIA";
            this.labelInfo_SIA.Size = new System.Drawing.Size(384, 162);
            this.labelInfo_SIA.TabIndex = 6;
            this.labelInfo_SIA.Text = resources.GetString("labelInfo_SIA.Text");
            this.labelInfo_SIA.Click += new System.EventHandler(this.labelInfo_SIA_Click);
            // 
            // FormAbout_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 229);
            this.Controls.Add(this.buttonOK_SIA);
            this.Controls.Add(this.pictureBoxAvatar_SIA);
            this.Controls.Add(this.labelInfo_SIA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_SIA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_SIA;
        private System.Windows.Forms.Label labelInfo_SIA;
    }
}