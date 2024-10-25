namespace TicTacToe_Canonigo {
    partial class GameForm {
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
            components = new System.ComponentModel.Container();
            player1WinsText = new Label();
            player2WinsText = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            turnText = new Label();
            roundText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // player1WinsText
            // 
            player1WinsText.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player1WinsText.Location = new Point(66, 24);
            player1WinsText.Name = "player1WinsText";
            player1WinsText.Size = new Size(230, 22);
            player1WinsText.TabIndex = 0;
            player1WinsText.Text = "{player1} wins: 0";
            // 
            // player2WinsText
            // 
            player2WinsText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            player2WinsText.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            player2WinsText.Location = new Point(310, 21);
            player2WinsText.Name = "player2WinsText";
            player2WinsText.RightToLeft = RightToLeft.No;
            player2WinsText.Size = new Size(272, 22);
            player2WinsText.TabIndex = 1;
            player2WinsText.Text = "{player2} wins: 0";
            player2WinsText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 45);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveBorder;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(588, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Location = new Point(174, 136);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(299, 296);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 1.5F);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(92, 92);
            button1.TabIndex = 0;
            button1.Tag = "play";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 1.5F);
            button2.Location = new Point(101, 3);
            button2.Name = "button2";
            button2.Size = new Size(92, 92);
            button2.TabIndex = 1;
            button2.Tag = "play";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI", 1.5F);
            button3.Location = new Point(199, 3);
            button3.Name = "button3";
            button3.Size = new Size(92, 92);
            button3.TabIndex = 2;
            button3.Tag = "play";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            // 
            // button4
            // 
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 1.5F);
            button4.Location = new Point(3, 101);
            button4.Name = "button4";
            button4.Size = new Size(92, 92);
            button4.TabIndex = 3;
            button4.Tag = "play";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Segoe UI", 1.5F);
            button5.Location = new Point(101, 101);
            button5.Name = "button5";
            button5.Size = new Size(92, 92);
            button5.TabIndex = 4;
            button5.Tag = "play";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Segoe UI", 1.5F);
            button6.Location = new Point(199, 101);
            button6.Name = "button6";
            button6.Size = new Size(92, 92);
            button6.TabIndex = 5;
            button6.Tag = "play";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Segoe UI", 1.5F);
            button7.Location = new Point(3, 199);
            button7.Name = "button7";
            button7.Size = new Size(92, 92);
            button7.TabIndex = 6;
            button7.Tag = "play";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Font = new Font("Segoe UI", 1.5F);
            button8.Location = new Point(101, 199);
            button8.Name = "button8";
            button8.Size = new Size(92, 92);
            button8.TabIndex = 7;
            button8.Tag = "play";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Font = new Font("Segoe UI", 1.5F);
            button9.Location = new Point(199, 199);
            button9.Name = "button9";
            button9.Size = new Size(92, 92);
            button9.TabIndex = 8;
            button9.Tag = "play";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            // 
            // turnText
            // 
            turnText.Anchor = AnchorStyles.Top;
            turnText.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            turnText.Location = new Point(159, 93);
            turnText.Name = "turnText";
            turnText.Size = new Size(326, 23);
            turnText.TabIndex = 5;
            turnText.Text = "{playername}'s turn";
            turnText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundText
            // 
            roundText.Anchor = AnchorStyles.Top;
            roundText.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundText.ForeColor = Color.ForestGreen;
            roundText.Location = new Point(159, 446);
            roundText.Name = "roundText";
            roundText.Size = new Size(326, 23);
            roundText.TabIndex = 6;
            roundText.Text = "ROUND 1";
            roundText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 527);
            Controls.Add(roundText);
            Controls.Add(turnText);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(player2WinsText);
            Controls.Add(player1WinsText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GameForm";
            Text = "GameForm";
            FormClosed += GameForm_FormClosed;
            Load += GameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label player1WinsText;
        private Label player2WinsText;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private System.Windows.Forms.Timer timer1;
        private Label turnText;
        private Label roundText;
    }
}