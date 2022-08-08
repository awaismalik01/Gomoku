namespace Gomoku
{
    partial class Gomoku
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
            this.START = new System.Windows.Forms.Button();
            this.Fivex5 = new System.Windows.Forms.RadioButton();
            this.Tenx10 = new System.Windows.Forms.RadioButton();
            this.Fifteenx15 = new System.Windows.Forms.RadioButton();
            this.Nineteenx19 = new System.Windows.Forms.RadioButton();
            this.Grid = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(184, 117);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(404, 95);
            this.START.TabIndex = 0;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.Start_Click);
            // 
            // Fivex5
            // 
            this.Fivex5.AutoSize = true;
            this.Fivex5.Location = new System.Drawing.Point(73, 42);
            this.Fivex5.Name = "Fivex5";
            this.Fivex5.Size = new System.Drawing.Size(51, 21);
            this.Fivex5.TabIndex = 1;
            this.Fivex5.TabStop = true;
            this.Fivex5.Text = "5x5";
            this.Fivex5.UseVisualStyleBackColor = true;
            this.Fivex5.CheckedChanged += new System.EventHandler(this.Fivex5_CheckedChanged);
            // 
            // Tenx10
            // 
            this.Tenx10.AutoSize = true;
            this.Tenx10.Location = new System.Drawing.Point(236, 42);
            this.Tenx10.Name = "Tenx10";
            this.Tenx10.Size = new System.Drawing.Size(67, 21);
            this.Tenx10.TabIndex = 2;
            this.Tenx10.TabStop = true;
            this.Tenx10.Text = "10x10";
            this.Tenx10.UseVisualStyleBackColor = true;
            this.Tenx10.CheckedChanged += new System.EventHandler(this.Tenx10_CheckedChanged);
            // 
            // Fifteenx15
            // 
            this.Fifteenx15.AutoSize = true;
            this.Fifteenx15.Location = new System.Drawing.Point(430, 42);
            this.Fifteenx15.Name = "Fifteenx15";
            this.Fifteenx15.Size = new System.Drawing.Size(67, 21);
            this.Fifteenx15.TabIndex = 3;
            this.Fifteenx15.TabStop = true;
            this.Fifteenx15.Text = "15x15";
            this.Fifteenx15.UseVisualStyleBackColor = true;
            this.Fifteenx15.CheckedChanged += new System.EventHandler(this.Fifteenx15_CheckedChanged);
            // 
            // Nineteenx19
            // 
            this.Nineteenx19.AutoSize = true;
            this.Nineteenx19.Location = new System.Drawing.Point(626, 42);
            this.Nineteenx19.Name = "Nineteenx19";
            this.Nineteenx19.Size = new System.Drawing.Size(67, 21);
            this.Nineteenx19.TabIndex = 4;
            this.Nineteenx19.TabStop = true;
            this.Nineteenx19.Text = "19x19";
            this.Nineteenx19.UseVisualStyleBackColor = true;
            this.Nineteenx19.CheckedChanged += new System.EventHandler(this.Nineteenx19_CheckedChanged);
            // 
            // Grid
            // 
            this.Grid.Location = new System.Drawing.Point(12, 218);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(776, 542);
            this.Grid.TabIndex = 5;
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // Gomoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 772);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Nineteenx19);
            this.Controls.Add(this.Fifteenx15);
            this.Controls.Add(this.Tenx10);
            this.Controls.Add(this.Fivex5);
            this.Controls.Add(this.START);
            this.Name = "Gomoku";
            this.Text = "Gomoku";
            this.Load += new System.EventHandler(this.Gomoku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.RadioButton Fivex5;
        private System.Windows.Forms.RadioButton Tenx10;
        private System.Windows.Forms.RadioButton Fifteenx15;
        private System.Windows.Forms.RadioButton Nineteenx19;
        private System.Windows.Forms.FlowLayoutPanel Grid;
    }
}

