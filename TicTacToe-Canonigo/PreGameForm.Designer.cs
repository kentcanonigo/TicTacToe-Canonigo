

using System.Resources;

namespace TicTacToe_Canonigo {
    partial class PreGameForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreGameForm));
            label1 = new Label();
            nameTextBox1 = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            cancelButton = new Button();
            button2 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            player2IconBox = new PictureBox();
            player1IconBox = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player2IconBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1IconBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("OldSansBlack", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 44);
            label1.TabIndex = 5;
            label1.Text = "'Say ngan ni player 1?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox1
            // 
            nameTextBox1.Location = new Point(142, 56);
            nameTextBox1.Mask = "LLLLLLLLLLLLLLLLL";
            nameTextBox1.Name = "nameTextBox1";
            nameTextBox1.Size = new Size(263, 23);
            nameTextBox1.TabIndex = 7;
            nameTextBox1.Tag = "1";
            nameTextBox1.TextChanged += nameTextBox_TextChanged;
            nameTextBox1.KeyPress += nameTextBox_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.Font = new Font("OldSansBlack", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 272);
            label2.Name = "label2";
            label2.Size = new Size(370, 44);
            label2.TabIndex = 8;
            label2.Text = "'Say ngan ni player 2?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(142, 319);
            maskedTextBox2.Mask = "LLLLLLLLLLLLLLLLL";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(263, 23);
            maskedTextBox2.TabIndex = 9;
            maskedTextBox2.Tag = "2";
            maskedTextBox2.TextChanged += nameTextBox_TextChanged;
            maskedTextBox2.KeyPress += nameTextBox_KeyPress;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Location = new Point(12, 127);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(614, 100);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icon1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(96, 97);
            button1.TabIndex = 0;
            button1.Tag = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += player1_iconClick;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icon2;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(105, 3);
            button3.Name = "button3";
            button3.Size = new Size(96, 97);
            button3.TabIndex = 1;
            button3.Tag = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += player1_iconClick;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.icon3;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(207, 3);
            button4.Name = "button4";
            button4.Size = new Size(96, 97);
            button4.TabIndex = 2;
            button4.Tag = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += player1_iconClick;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.icon4;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(309, 3);
            button5.Name = "button5";
            button5.Size = new Size(96, 97);
            button5.TabIndex = 3;
            button5.Tag = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += player1_iconClick;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.icon5;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(411, 3);
            button6.Name = "button6";
            button6.Size = new Size(96, 97);
            button6.TabIndex = 4;
            button6.Tag = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += player1_iconClick;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.icon6;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Location = new Point(513, 3);
            button7.Name = "button7";
            button7.Size = new Size(96, 97);
            button7.TabIndex = 5;
            button7.Tag = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += player1_iconClick;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.IndianRed;
            cancelButton.Location = new Point(61, 489);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(140, 36);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Ay nalang!";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Location = new Point(405, 489);
            button2.Name = "button2";
            button2.Size = new Size(140, 36);
            button2.TabIndex = 13;
            button2.Text = "Payts!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += confirmButton_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Controls.Add(button9);
            flowLayoutPanel2.Controls.Add(button10);
            flowLayoutPanel2.Controls.Add(button11);
            flowLayoutPanel2.Controls.Add(button12);
            flowLayoutPanel2.Controls.Add(button13);
            flowLayoutPanel2.Location = new Point(12, 363);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(614, 100);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // button8
            // 
            button8.BackgroundImage = Properties.Resources.icon1;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(96, 97);
            button8.TabIndex = 0;
            button8.Tag = "1";
            button8.UseVisualStyleBackColor = true;
            button8.Click += player2_iconClick;
            // 
            // button9
            // 
            button9.BackgroundImage = Properties.Resources.icon2;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Location = new Point(105, 3);
            button9.Name = "button9";
            button9.Size = new Size(96, 97);
            button9.TabIndex = 1;
            button9.Tag = "2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += player2_iconClick;
            // 
            // button10
            // 
            button10.BackgroundImage = Properties.Resources.icon3;
            button10.BackgroundImageLayout = ImageLayout.Stretch;
            button10.Location = new Point(207, 3);
            button10.Name = "button10";
            button10.Size = new Size(96, 97);
            button10.TabIndex = 2;
            button10.Tag = "3";
            button10.UseVisualStyleBackColor = true;
            button10.Click += player2_iconClick;
            // 
            // button11
            // 
            button11.BackgroundImage = Properties.Resources.icon4;
            button11.BackgroundImageLayout = ImageLayout.Stretch;
            button11.Location = new Point(309, 3);
            button11.Name = "button11";
            button11.Size = new Size(96, 97);
            button11.TabIndex = 3;
            button11.Tag = "4";
            button11.UseVisualStyleBackColor = true;
            button11.Click += player2_iconClick;
            // 
            // button12
            // 
            button12.BackgroundImage = Properties.Resources.icon5;
            button12.BackgroundImageLayout = ImageLayout.Stretch;
            button12.Location = new Point(411, 3);
            button12.Name = "button12";
            button12.Size = new Size(96, 97);
            button12.TabIndex = 4;
            button12.Tag = "5";
            button12.UseVisualStyleBackColor = true;
            button12.Click += player2_iconClick;
            // 
            // button13
            // 
            button13.BackgroundImage = Properties.Resources.icon6;
            button13.BackgroundImageLayout = ImageLayout.Stretch;
            button13.Location = new Point(513, 3);
            button13.Name = "button13";
            button13.Size = new Size(96, 97);
            button13.TabIndex = 5;
            button13.Tag = "6";
            button13.UseVisualStyleBackColor = true;
            button13.Click += player2_iconClick;
            // 
            // player2IconBox
            // 
            player2IconBox.BackColor = SystemColors.ActiveBorder;
            player2IconBox.BackgroundImageLayout = ImageLayout.Stretch;
            player2IconBox.Location = new Point(12, 266);
            player2IconBox.Name = "player2IconBox";
            player2IconBox.Size = new Size(74, 76);
            player2IconBox.TabIndex = 14;
            player2IconBox.TabStop = false;
            // 
            // player1IconBox
            // 
            player1IconBox.BackColor = SystemColors.ActiveBorder;
            player1IconBox.BackgroundImageLayout = ImageLayout.Stretch;
            player1IconBox.Location = new Point(15, 9);
            player1IconBox.Name = "player1IconBox";
            player1IconBox.Size = new Size(74, 76);
            player1IconBox.TabIndex = 15;
            player1IconBox.TabStop = false;
            // 
            // PreGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 537);
            Controls.Add(player1IconBox);
            Controls.Add(player2IconBox);
            Controls.Add(button2);
            Controls.Add(cancelButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(maskedTextBox2);
            Controls.Add(label2);
            Controls.Add(nameTextBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PreGameForm";
            Text = "Info";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)player2IconBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1IconBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private MaskedTextBox nameTextBox1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button cancelButton;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private PictureBox player2IconBox;
        private PictureBox player1IconBox;
    }
}