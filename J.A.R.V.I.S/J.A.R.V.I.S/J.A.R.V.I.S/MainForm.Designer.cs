namespace J.A.R.V.I.S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AI = new System.Windows.Forms.ListView();
            this.I = new System.Windows.Forms.ListView();
            this.Image = new System.Windows.Forms.PictureBox();
            this.MadeBy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // AI
            // 
            this.AI.BackColor = System.Drawing.SystemColors.InfoText;
            this.AI.Dock = System.Windows.Forms.DockStyle.Left;
            this.AI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AI.ForeColor = System.Drawing.Color.Turquoise;
            this.AI.FullRowSelect = true;
            this.AI.HideSelection = false;
            this.AI.Location = new System.Drawing.Point(0, 0);
            this.AI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AI.Name = "AI";
            this.AI.Size = new System.Drawing.Size(466, 729);
            this.AI.TabIndex = 2;
            this.AI.TileSize = new System.Drawing.Size(328, 54);
            this.AI.UseCompatibleStateImageBehavior = false;
            this.AI.View = System.Windows.Forms.View.Tile;
            // 
            // I
            // 
            this.I.BackColor = System.Drawing.SystemColors.InfoText;
            this.I.Dock = System.Windows.Forms.DockStyle.Right;
            this.I.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.I.ForeColor = System.Drawing.Color.Turquoise;
            this.I.FullRowSelect = true;
            this.I.HideSelection = false;
            this.I.Location = new System.Drawing.Point(915, 0);
            this.I.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(466, 729);
            this.I.TabIndex = 2;
            this.I.TileSize = new System.Drawing.Size(328, 54);
            this.I.UseCompatibleStateImageBehavior = false;
            this.I.View = System.Windows.Forms.View.Tile;
            // 
            // Image
            // 
            this.Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.Location = new System.Drawing.Point(466, 0);
            this.Image.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(449, 729);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Image.TabIndex = 5;
            this.Image.TabStop = false;
            // 
            // MadeBy
            // 
            this.MadeBy.BackColor = System.Drawing.SystemColors.InfoText;
            this.MadeBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.MadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MadeBy.ForeColor = System.Drawing.Color.Turquoise;
            this.MadeBy.Location = new System.Drawing.Point(466, 0);
            this.MadeBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MadeBy.Name = "MadeBy";
            this.MadeBy.ReadOnly = true;
            this.MadeBy.Size = new System.Drawing.Size(449, 30);
            this.MadeBy.TabIndex = 6;
            this.MadeBy.Text = "MADE BY MR. DENIS";
            this.MadeBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1381, 729);
            this.Controls.Add(this.MadeBy);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.I);
            this.Controls.Add(this.AI);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J.A.R.V.I.S";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AI;
        private System.Windows.Forms.ListView I;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.TextBox MadeBy;
    }
}

