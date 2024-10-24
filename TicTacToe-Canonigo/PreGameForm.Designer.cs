

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
            label1 = new Label();
            nameTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("OldSansBlack", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 98);
            label1.TabIndex = 5;
            label1.Text = "'Say ngan nimo choi?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(152, 84);
            nameTextBox.Mask = "LLLLLLLLLLLLLLLLL";
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PromptChar = ' ';
            nameTextBox.Size = new Size(263, 23);
            nameTextBox.TabIndex = 7;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            // 
            // PreGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 271);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PreGameForm";
            Text = "GameForm";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private MaskedTextBox nameTextBox;
    }
}