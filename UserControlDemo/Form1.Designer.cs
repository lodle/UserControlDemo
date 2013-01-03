namespace UserControlDemo
{
    partial class Form1
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
            this.ButUser1 = new System.Windows.Forms.Button();
            this.ButUser2 = new System.Windows.Forms.Button();
            this.PanPlaceHolder = new System.Windows.Forms.UserControl();
            this.SuspendLayout();
            // 
            // ButUser1
            // 
            this.ButUser1.Location = new System.Drawing.Point(41, 310);
            this.ButUser1.Name = "ButUser1";
            this.ButUser1.Size = new System.Drawing.Size(75, 23);
            this.ButUser1.TabIndex = 0;
            this.ButUser1.Text = "User 1";
            this.ButUser1.UseVisualStyleBackColor = true;
            this.ButUser1.Click += new System.EventHandler(this.ButUser1_Click);
            // 
            // ButUser2
            // 
            this.ButUser2.Location = new System.Drawing.Point(123, 310);
            this.ButUser2.Name = "ButUser2";
            this.ButUser2.Size = new System.Drawing.Size(75, 23);
            this.ButUser2.TabIndex = 1;
            this.ButUser2.Text = "User 2";
            this.ButUser2.UseVisualStyleBackColor = true;
            this.ButUser2.Click += new System.EventHandler(this.ButUser2_Click);
            // 
            // PanPlaceHolder
            // 
            this.PanPlaceHolder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanPlaceHolder.Location = new System.Drawing.Point(13, 13);
            this.PanPlaceHolder.Name = "PanPlaceHolder";
            this.PanPlaceHolder.Size = new System.Drawing.Size(470, 291);
            this.PanPlaceHolder.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 345);
            this.Controls.Add(this.PanPlaceHolder);
            this.Controls.Add(this.ButUser2);
            this.Controls.Add(this.ButUser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButUser1;
        private System.Windows.Forms.Button ButUser2;
        private System.Windows.Forms.UserControl PanPlaceHolder;
    }
}

