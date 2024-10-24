using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Canonigo {
    public partial class PreGameForm : Form {
        public PreGameForm() {
            InitializeComponent();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            // Get the current text of the MaskedTextBox
            string currentText = nameTextBox.Text;

            // Allow letters and control keys (e.g., backspace)
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) {
                return;
            }

            // Allow space only if it's not the first or last character
            if (e.KeyChar == ' ') {
                if (nameTextBox.SelectionStart == 0 || nameTextBox.SelectionStart == currentText.Length) {
                    e.Handled = true; // Prevent space at the start or end
                }
            }
            else {
                e.Handled = true; // Prevent non-letter, non-space characters
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e) {
            nameTextBox.Text = nameTextBox.Text.Trim();
        }
    }
}
