using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Canonigo {
    public partial class PreGameForm : Form {

        private static readonly List<string> randomNames = new List<string>
        {
            "Ivory Surebaka", "Sex Smallinhog", "Drey Niambak", "Gabjel Wackin", "Kelvin Adidas", "Tobaco Menendez", "John Alegre", "Ken Kantotigo", "Kinetic Malumanay", "Add He Lorlor"
        };

        public PreGameForm() {
            InitializeComponent();
            Load();
        }

        private void Load() {
            player1IconBox.BackgroundImage = Player.Instance.PlayerIcon;
            player2IconBox.BackgroundImage = Player.Instance2.PlayerIcon;
        }

        // This is for sanitization of name
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            // Get the current text of the MaskedTextBox
            string currentText = nameTextBox1.Text;

            // Allow letters and control keys (e.g., backspace)
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)) {
                return;
            }

            // Allow space only if it's not the first or last character
            if (e.KeyChar == ' ') {
                if (nameTextBox1.SelectionStart == 0 || nameTextBox1.SelectionStart == currentText.Length) {
                    e.Handled = true; // Prevent space at the start or end
                }
            }
            else {
                e.Handled = true; // Prevent non-letter, non-space characters
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e) {
            MaskedTextBox textBox = sender as MaskedTextBox;

            if (textBox != null) {
                // Trim the text to avoid leading/trailing whitespace
                textBox.Text = textBox.Text.Trim();

                // Check the Tag to assign the name to the correct player
                if (int.Parse((string)textBox.Tag) == 1) {
                    Player.Instance.PlayerName = textBox.Text;
                }
                else if (int.Parse((string)textBox.Tag) == 2) {
                    Player.Instance2.PlayerName = textBox.Text;
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e) {
            // Checks for icons
            if (Player.Instance.PlayerIcon == null || Player.Instance2.PlayerIcon == null) {
                MessageBox.Show("Wa lage moy icon?!", "HOY!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Player icons are not set!");
                return;
            }
            else if (Player.Instance.PlayerIcon == Player.Instance2.PlayerIcon) {
                MessageBox.Show("Di pwede kapareha oy!", "HOY!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Players cannot have the same icon!");
                return;
            }

            // Check if player names are set
            if (string.IsNullOrWhiteSpace(Player.Instance.PlayerName) || string.IsNullOrWhiteSpace(Player.Instance2.PlayerName)) {
                // Show dialog to ask the player if they want to go back or continue with generated names
                DialogResult result = MessageBox.Show(
                    "Hoy usa ninyo walay ngalan. Nahan ka mubalik para butngan?",
                    "Kuwang ug ngalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes) {
                    // User chose to go back to add names; simply return to allow them to edit the names
                    Debug.WriteLine("User chose to go back and add names.");
                    return;
                }
                else {
                    // Random name assignment if player names are empty
                    Random random = new Random();

                    if (string.IsNullOrWhiteSpace(Player.Instance.PlayerName)) {
                        Player.Instance.PlayerName = randomNames[random.Next(randomNames.Count)];
                    }
                    if (string.IsNullOrWhiteSpace(Player.Instance2.PlayerName)) {
                        Player.Instance2.PlayerName = randomNames[random.Next(randomNames.Count)];
                    }

                    MessageBox.Show("Generating random ahh names.", "Proceeding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Close();
            Debug.WriteLine("Clicked!");
            // Proceed with the rest of the game setup or confirmation logic
        }


        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
            mainMenuForm mainMenuForm = new mainMenuForm();
            mainMenuForm.Show();
        }

        // Im using just two functions here that listen to the corresponding buttons' events so we don't end up with a helleheubuvlalot of repeat functions. (DRY)

        private void player1_iconClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button != null) {
                // Retrieve the icon ID from the button's Tag
                int iconId = int.Parse((string)button.Tag);

                // Set the Player 1's icon ID and icon image using IconManager
                Player.Instance.PlayerIconId = iconId;
                Player.Instance.PlayerIcon = IconManager.Icons[iconId];

                // Update the display of Player 1's selected icon
                player1IconBox.BackgroundImage = Player.Instance.PlayerIcon;
            }
        }

        private void player2_iconClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button != null) {
                // Retrieve the icon ID from the button's Tag
                int iconId = int.Parse((string)button.Tag);


                // Set the Player 2's icon ID and icon image using IconManager
                Player.Instance2.PlayerIconId = iconId;
                Player.Instance2.PlayerIcon = IconManager.Icons[iconId];

                // Update the display of Player 2's selected icon
                player2IconBox.BackgroundImage = Player.Instance2.PlayerIcon;
            }
        }


    }
}
