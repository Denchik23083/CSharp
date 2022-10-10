namespace TestAI
{
    partial class MainForm
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
            this.ListCommands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListCommands
            // 
            this.ListCommands.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ListCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCommands.ForeColor = System.Drawing.Color.Turquoise;
            this.ListCommands.FormattingEnabled = true;
            this.ListCommands.ItemHeight = 25;
            this.ListCommands.Location = new System.Drawing.Point(0, 0);
            this.ListCommands.Name = "ListCommands";
            this.ListCommands.Size = new System.Drawing.Size(800, 450);
            this.ListCommands.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListCommands);
            this.Name = "MainForm";
            this.Text = "Karen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListCommands;
    }
}

