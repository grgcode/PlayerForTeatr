namespace PlayerForTeatr
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxHelp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHelp.Location = new System.Drawing.Point(10, 0);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHelp.Size = new System.Drawing.Size(423, 368);
            this.textBoxHelp.TabIndex = 0;
            this.textBoxHelp.Text = resources.GetString("textBoxHelp.Text");
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 368);
            this.Controls.Add(this.textBoxHelp);
            this.Name = "FormHelp";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Player for Teatr Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHelp;
    }
}