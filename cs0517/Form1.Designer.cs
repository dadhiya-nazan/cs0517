namespace cs0517
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Light = new Button();
            Up = new Button();
            Down = new Button();
            Left = new Button();
            Kenitikun = new Label();
            SuspendLayout();
            // 
            // Light
            // 
            Light.BackColor = Color.FromArgb(128, 255, 255);
            Light.Font = new Font("源ノ角ゴシック Code JP R", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Light.Location = new Point(660, 276);
            Light.Name = "Light";
            Light.Size = new Size(75, 75);
            Light.TabIndex = 1;
            Light.Text = "右";
            Light.UseVisualStyleBackColor = false;
            Light.Click += button1_Click;
            // 
            // Up
            // 
            Up.BackColor = Color.FromArgb(128, 255, 255);
            Up.Font = new Font("源ノ角ゴシック Code JP R", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Up.Location = new Point(579, 195);
            Up.Name = "Up";
            Up.Size = new Size(75, 75);
            Up.TabIndex = 2;
            Up.Text = "上";
            Up.UseVisualStyleBackColor = false;
            Up.Click += Up_Click;
            // 
            // Down
            // 
            Down.BackColor = Color.FromArgb(128, 255, 255);
            Down.Font = new Font("源ノ角ゴシック Code JP R", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Down.Location = new Point(579, 363);
            Down.Name = "Down";
            Down.Size = new Size(75, 75);
            Down.TabIndex = 3;
            Down.Text = "下";
            Down.UseVisualStyleBackColor = false;
            Down.Click += button2_Click;
            // 
            // Left
            // 
            Left.BackColor = Color.FromArgb(128, 255, 255);
            Left.Font = new Font("源ノ角ゴシック Code JP R", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            Left.Location = new Point(498, 276);
            Left.Name = "Left";
            Left.Size = new Size(75, 75);
            Left.TabIndex = 4;
            Left.Text = "左";
            Left.UseVisualStyleBackColor = false;
            Left.Click += Left_Click;
            // 
            // Kenitikun
            // 
            Kenitikun.AutoSize = true;
            Kenitikun.BackColor = SystemColors.ButtonFace;
            Kenitikun.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Kenitikun.ForeColor = Color.FromArgb(0, 192, 0);
            Kenitikun.Location = new Point(366, 207);
            Kenitikun.Name = "Kenitikun";
            Kenitikun.Size = new Size(86, 32);
            Kenitikun.TabIndex = 5;
            Kenitikun.Text = "(。 ∀°)";
            Kenitikun.TextAlign = ContentAlignment.TopRight;
            Kenitikun.Click += Sirasu_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Kenitikun);
            Controls.Add(Left);
            Controls.Add(Down);
            Controls.Add(Up);
            Controls.Add(Light);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button Light;
        private Button Up;
        private Button Down;
        private Button Left;
        private Label Kenitikun;
    }
}