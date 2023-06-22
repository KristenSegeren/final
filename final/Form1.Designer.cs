namespace final
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.block1label = new System.Windows.Forms.Label();
            this.block2Label = new System.Windows.Forms.Label();
            this.block3Label = new System.Windows.Forms.Label();
            this.block4Label = new System.Windows.Forms.Label();
            this.block5Label = new System.Windows.Forms.Label();
            this.block6Label = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // block1label
            // 
            this.block1label.BackColor = System.Drawing.Color.Transparent;
            this.block1label.ForeColor = System.Drawing.Color.White;
            this.block1label.Location = new System.Drawing.Point(12, 39);
            this.block1label.Name = "block1label";
            this.block1label.Size = new System.Drawing.Size(72, 56);
            this.block1label.TabIndex = 0;
            this.block1label.Text = "0";
            this.block1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block2Label
            // 
            this.block2Label.BackColor = System.Drawing.Color.Transparent;
            this.block2Label.ForeColor = System.Drawing.Color.White;
            this.block2Label.Location = new System.Drawing.Point(161, 31);
            this.block2Label.Name = "block2Label";
            this.block2Label.Size = new System.Drawing.Size(64, 86);
            this.block2Label.TabIndex = 1;
            this.block2Label.Text = "0";
            this.block2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block3Label
            // 
            this.block3Label.BackColor = System.Drawing.Color.Transparent;
            this.block3Label.ForeColor = System.Drawing.Color.White;
            this.block3Label.Location = new System.Drawing.Point(280, 39);
            this.block3Label.Name = "block3Label";
            this.block3Label.Size = new System.Drawing.Size(111, 70);
            this.block3Label.TabIndex = 2;
            this.block3Label.Text = "0";
            this.block3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block4Label
            // 
            this.block4Label.BackColor = System.Drawing.Color.Transparent;
            this.block4Label.ForeColor = System.Drawing.Color.White;
            this.block4Label.Location = new System.Drawing.Point(86, 100);
            this.block4Label.Name = "block4Label";
            this.block4Label.Size = new System.Drawing.Size(69, 89);
            this.block4Label.TabIndex = 3;
            this.block4Label.Text = "0";
            this.block4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block5Label
            // 
            this.block5Label.BackColor = System.Drawing.Color.Transparent;
            this.block5Label.ForeColor = System.Drawing.Color.White;
            this.block5Label.Location = new System.Drawing.Point(221, 109);
            this.block5Label.Name = "block5Label";
            this.block5Label.Size = new System.Drawing.Size(65, 80);
            this.block5Label.TabIndex = 4;
            this.block5Label.Text = "0";
            this.block5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block6Label
            // 
            this.block6Label.BackColor = System.Drawing.Color.Transparent;
            this.block6Label.ForeColor = System.Drawing.Color.White;
            this.block6Label.Location = new System.Drawing.Point(161, 175);
            this.block6Label.Name = "block6Label";
            this.block6Label.Size = new System.Drawing.Size(69, 74);
            this.block6Label.TabIndex = 5;
            this.block6Label.Text = "0";
            this.block6Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-1, -34);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(365, 575);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "    Welcome To Kristen\'s Super            Awesome Game Thing          Press space" +
    " to begin";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 449);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.block6Label);
            this.Controls.Add(this.block5Label);
            this.Controls.Add(this.block4Label);
            this.Controls.Add(this.block3Label);
            this.Controls.Add(this.block2Label);
            this.Controls.Add(this.block1label);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kristens super awesome game thing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label block1label;
        private System.Windows.Forms.Label block2Label;
        private System.Windows.Forms.Label block3Label;
        private System.Windows.Forms.Label block4Label;
        private System.Windows.Forms.Label block5Label;
        private System.Windows.Forms.Label block6Label;
        private System.Windows.Forms.Label titleLabel;
    }
}

