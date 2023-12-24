namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    partial class FormManual_SIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManual_SIA));
            this.buttonNext_SIA = new System.Windows.Forms.Button();
            this.buttonPrev_SIA = new System.Windows.Forms.Button();
            this.pictureBoxGuide_SIA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNext_SIA
            // 
            this.buttonNext_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext_SIA.Location = new System.Drawing.Point(832, 616);
            this.buttonNext_SIA.Name = "buttonNext_SIA";
            this.buttonNext_SIA.Size = new System.Drawing.Size(188, 42);
            this.buttonNext_SIA.TabIndex = 0;
            this.buttonNext_SIA.Text = "Следующая страница";
            this.buttonNext_SIA.UseVisualStyleBackColor = true;
            this.buttonNext_SIA.Click += new System.EventHandler(this.buttonNext_SIA_Click);
            // 
            // buttonPrev_SIA
            // 
            this.buttonPrev_SIA.Enabled = false;
            this.buttonPrev_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev_SIA.Location = new System.Drawing.Point(76, 616);
            this.buttonPrev_SIA.Name = "buttonPrev_SIA";
            this.buttonPrev_SIA.Size = new System.Drawing.Size(188, 42);
            this.buttonPrev_SIA.TabIndex = 1;
            this.buttonPrev_SIA.Text = "Предыдущая страница";
            this.buttonPrev_SIA.UseVisualStyleBackColor = true;
            this.buttonPrev_SIA.Click += new System.EventHandler(this.buttonPrev_SIA_Click);
            // 
            // pictureBoxGuide_SIA
            // 
            this.pictureBoxGuide_SIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuide_SIA.BackgroundImage")));
            this.pictureBoxGuide_SIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGuide_SIA.Location = new System.Drawing.Point(52, 12);
            this.pictureBoxGuide_SIA.Name = "pictureBoxGuide_SIA";
            this.pictureBoxGuide_SIA.Size = new System.Drawing.Size(987, 588);
            this.pictureBoxGuide_SIA.TabIndex = 2;
            this.pictureBoxGuide_SIA.TabStop = false;
            // 
            // FormManual_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 670);
            this.Controls.Add(this.pictureBoxGuide_SIA);
            this.Controls.Add(this.buttonPrev_SIA);
            this.Controls.Add(this.buttonNext_SIA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManual_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство Пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNext_SIA;
        private System.Windows.Forms.Button buttonPrev_SIA;
        private System.Windows.Forms.PictureBox pictureBoxGuide_SIA;
    }
}