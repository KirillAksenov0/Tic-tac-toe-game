namespace tic_tac_toe
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
            LeftUpButton = new Button();
            CenterButton = new Button();
            LeftButton = new Button();
            RightUpButton = new Button();
            UpButton = new Button();
            DownButton = new Button();
            LeftDownButton = new Button();
            RightButton = new Button();
            RightDownButton = new Button();
            XCount = new Label();
            OCount = new Label();
            SuspendLayout();
            // 
            // LeftUpButton
            // 
            LeftUpButton.FlatAppearance.MouseDownBackColor = Color.Chocolate;
            LeftUpButton.FlatAppearance.MouseOverBackColor = Color.Red;
            LeftUpButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LeftUpButton.ForeColor = SystemColors.Desktop;
            LeftUpButton.Location = new Point(0, 108);
            LeftUpButton.Name = "LeftUpButton";
            LeftUpButton.Size = new Size(88, 72);
            LeftUpButton.TabIndex = 0;
            LeftUpButton.TabStop = false;
            LeftUpButton.UseVisualStyleBackColor = true;
            LeftUpButton.Click += LeftUpButton_Click;
            // 
            // CenterButton
            // 
            CenterButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CenterButton.ForeColor = SystemColors.Desktop;
            CenterButton.Location = new Point(84, 177);
            CenterButton.Name = "CenterButton";
            CenterButton.Size = new Size(88, 72);
            CenterButton.TabIndex = 1;
            CenterButton.TabStop = false;
            CenterButton.UseVisualStyleBackColor = true;
            CenterButton.Click += CenterButton_Click;
            // 
            // LeftButton
            // 
            LeftButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LeftButton.ForeColor = SystemColors.Desktop;
            LeftButton.Location = new Point(0, 177);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(88, 72);
            LeftButton.TabIndex = 2;
            LeftButton.TabStop = false;
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightUpButton
            // 
            RightUpButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            RightUpButton.ForeColor = SystemColors.Desktop;
            RightUpButton.Location = new Point(167, 108);
            RightUpButton.Name = "RightUpButton";
            RightUpButton.Size = new Size(87, 72);
            RightUpButton.TabIndex = 3;
            RightUpButton.TabStop = false;
            RightUpButton.UseVisualStyleBackColor = true;
            RightUpButton.Click += RightUpButton_Click;
            // 
            // UpButton
            // 
            UpButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UpButton.ForeColor = SystemColors.Desktop;
            UpButton.Location = new Point(84, 108);
            UpButton.Name = "UpButton";
            UpButton.Size = new Size(87, 72);
            UpButton.TabIndex = 4;
            UpButton.TabStop = false;
            UpButton.UseVisualStyleBackColor = true;
            UpButton.Click += UpButton_Click;
            // 
            // DownButton
            // 
            DownButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DownButton.ForeColor = SystemColors.Desktop;
            DownButton.Location = new Point(84, 242);
            DownButton.Name = "DownButton";
            DownButton.Size = new Size(88, 72);
            DownButton.TabIndex = 5;
            DownButton.TabStop = false;
            DownButton.UseVisualStyleBackColor = true;
            DownButton.Click += DownButton_Click;
            // 
            // LeftDownButton
            // 
            LeftDownButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LeftDownButton.ForeColor = SystemColors.Desktop;
            LeftDownButton.Location = new Point(0, 242);
            LeftDownButton.Name = "LeftDownButton";
            LeftDownButton.Size = new Size(88, 72);
            LeftDownButton.TabIndex = 6;
            LeftDownButton.TabStop = false;
            LeftDownButton.UseVisualStyleBackColor = true;
            LeftDownButton.Click += LeftDownButton_Click;
            // 
            // RightButton
            // 
            RightButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            RightButton.ForeColor = SystemColors.Desktop;
            RightButton.Location = new Point(167, 177);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(87, 72);
            RightButton.TabIndex = 7;
            RightButton.TabStop = false;
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // RightDownButton
            // 
            RightDownButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            RightDownButton.ForeColor = SystemColors.Desktop;
            RightDownButton.Location = new Point(167, 242);
            RightDownButton.Name = "RightDownButton";
            RightDownButton.Size = new Size(87, 72);
            RightDownButton.TabIndex = 8;
            RightDownButton.TabStop = false;
            RightDownButton.UseVisualStyleBackColor = true;
            RightDownButton.Click += RightDownButton_Click;
            // 
            // XCount
            // 
            XCount.AutoSize = true;
            XCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            XCount.ForeColor = Color.Red;
            XCount.Location = new Point(73, 36);
            XCount.Name = "XCount";
            XCount.Size = new Size(0, 54);
            XCount.TabIndex = 9;
            // 
            // OCount
            // 
            OCount.AutoSize = true;
            OCount.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            OCount.ForeColor = Color.DeepSkyBlue;
            OCount.Location = new Point(145, 36);
            OCount.Name = "OCount";
            OCount.Size = new Size(0, 54);
            OCount.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 312);
            Controls.Add(RightDownButton);
            Controls.Add(DownButton);
            Controls.Add(LeftDownButton);
            Controls.Add(RightButton);
            Controls.Add(CenterButton);
            Controls.Add(RightUpButton);
            Controls.Add(UpButton);
            Controls.Add(LeftUpButton);
            Controls.Add(LeftButton);
            Controls.Add(OCount);
            Controls.Add(XCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LeftUpButton;
        private Button CenterButton;
        private Button LeftButton;
        private Button RightUpButton;
        private Button UpButton;
        private Button DownButton;
        private Button LeftDownButton;
        private Button RightButton;
        private Button RightDownButton;
        private Label XCount;
        private Label OCount;
    }
}