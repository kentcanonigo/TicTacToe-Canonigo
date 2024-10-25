namespace TicTacToe_Canonigo {
    partial class HelpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(644, 32);
            label1.TabIndex = 0;
            label1.Text = "The game is played on a grid that's 3 squares by 3 squares.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 50);
            label2.Name = "label2";
            label2.Size = new Size(527, 30);
            label2.TabIndex = 1;
            label2.Text = "Players take turns putting their marks in empty squares.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(783, 25);
            label3.TabIndex = 2;
            label3.Text = "The first player to get 3 of her marks in a row (up, down, across, or diagonally) is the winner.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.samplephoto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(61, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(674, 303);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(294, 440);
            button1.Name = "button1";
            button1.Size = new Size(214, 59);
            button1.TabIndex = 4;
            button1.Text = "AW SIGE!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HelpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HelpForm";
            Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}