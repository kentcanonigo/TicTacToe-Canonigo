namespace TicTacToe_Canonigo {
    partial class mainMenuForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            startButton = new Button();
            helpButton = new Button();
            aboutButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            startButton.Location = new Point(320, 99);
            startButton.Name = "startButton";
            startButton.Size = new Size(157, 78);
            startButton.TabIndex = 0;
            startButton.Text = "Sugod!";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // helpButton
            // 
            helpButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            helpButton.Location = new Point(320, 183);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(157, 85);
            helpButton.TabIndex = 1;
            helpButton.Text = "Tabang";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            aboutButton.Location = new Point(320, 274);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(157, 81);
            aboutButton.TabIndex = 2;
            aboutButton.Text = "Huh?";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            exitButton.Location = new Point(320, 361);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(157, 86);
            exitButton.TabIndex = 3;
            exitButton.Text = "Dili nako!";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("OldSansBlack", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 96);
            label1.TabIndex = 4;
            label1.Text = "Kent's Tic Tac Toe!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5939865F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.8120289F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5939827F));
            tableLayoutPanel1.Controls.Add(startButton, 1, 1);
            tableLayoutPanel1.Controls.Add(helpButton, 1, 2);
            tableLayoutPanel1.Controls.Add(aboutButton, 1, 3);
            tableLayoutPanel1.Controls.Add(exitButton, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "mainMenuForm";
            Text = "Main Menu";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button helpButton;
        private Button aboutButton;
        private Button exitButton;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
