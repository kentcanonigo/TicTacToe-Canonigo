using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Canonigo {
    public partial class GameForm : Form {
        Player currentPlayer; // calling the player class 

        private int currentRound = 1;
        private int player1Score = 0;
        private int player2Score = 0;
        public GameForm() {
            InitializeComponent();
            NewGame();
        }

        private void NewGame() {
            currentRound = 1;
            player1Score = 0;
            player2Score = 0;
            pictureBox1.BackgroundImage = Player.Instance.PlayerIcon;
            pictureBox2.BackgroundImage = Player.Instance2.PlayerIcon;
            turnText.Text = Player.Instance.PlayerName + "'s turn";
            roundText.Text = $"Round {currentRound}";
            // First player is player 1
            currentPlayer = Player.Instance;

            ResetButtons();

            RefreshUI();
        }

        private void ResetButtons() {
            //check each of the button with a tag of play
            foreach (Control curButton in flowLayoutPanel1.Controls) {
                if (curButton is Button && (string)curButton.Tag == "play") {
                    ((Button)curButton).Enabled = true; // change them all back to enabled or clickable
                    ((Button)curButton).Text = "?"; // set the text to question mark
                    ((Button)curButton).BackColor = default(Color); // change the background colour to default button colors
                    ((Button)curButton).BackgroundImage = null;
                }
            }
        }

        private void RefreshUI() {
            // Display "FINAL ROUND" if the current round is 5, otherwise show the round number
            if (currentRound == 5) {
                roundText.Text = "FINAL ROUND";
            }
            else {
                roundText.Text = $"Round {currentRound}";
            }

            player1WinsText.Text = Player.Instance.PlayerName + " wins: " + player1Score;
            player2WinsText.Text = Player.Instance2.PlayerName + " wins: " + player2Score;
        }

        private void NextRound() {

            currentRound++; // Increment the round counter
            ResetButtons();

            if (currentRound > 5) {
                // Determine the grand winner based on scores
                string grandWinner;
                if (player1Score > player2Score) {
                    grandWinner = Player.Instance.PlayerName;
                }
                else if (player2Score > player1Score) {
                    grandWinner = Player.Instance2.PlayerName;
                }
                else {
                    grandWinner = "No one! It's atay!";
                }

                // Display the grand winner in a message box
                MessageBox.Show($"SHEESH DAUG SI {grandWinner}", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ask if they want a rematch
                DialogResult result = MessageBox.Show("Rematch??!", "Rematch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Start a new game if the user wants a rematch
                    NewGame();
                }
                else {
                    // Close the game form or return to the main menu
                    this.Close();
                    mainMenuForm.Instance.Show(); // Assuming MainMenuForm is a singleton
                }
            }

            RefreshUI();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainMenuForm.Instance.Show();
        }

        private void GameForm_Load(object sender, EventArgs e) {

        }

        private void playerClick(object sender, EventArgs e) {
            var button = (Button)sender; // find which button was clicked
            string playerString;

            // Swapping turns logic (O is player 1, X is player 2)
            if (currentPlayer == Player.Instance) {
                playerString = "O";
            } else {
                playerString = "X";
            }

            button.Text = playerString; // change the button text to player X
            button.Enabled = false; // disable the button
            button.BackgroundImage = currentPlayer.PlayerIcon; // change the player colour to Cyan

            Check(); // check if the player won

            if (currentPlayer == Player.Instance) {
                currentPlayer = Player.Instance2;
                turnText.Text = Player.Instance2.PlayerName + "'s turn";
            }
            else {
                currentPlayer = Player.Instance;
                turnText.Text = Player.Instance.PlayerName + "'s turn";
            }
        }

        private void Check() {
            // winning checks
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X") {
                player2Score++;
                MessageBox.Show($"{Player.Instance2.PlayerName} Wins");
                NextRound();
                return;
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O") {
                player1Score++;
                MessageBox.Show($"{Player.Instance.PlayerName} Wins");
                NextRound(); // next round
                return;
            }

            // Check for a draw if all buttons are pressed
            bool isDraw = true;
            foreach (Control control in flowLayoutPanel1.Controls) {
                if (control is Button button && (string)button.Tag == "play" && button.Text == "?") {
                    isDraw = false;
                    break;
                }
            }

            // If it's a draw, reset the board but don't advance the round
            if (isDraw) {
                MessageBox.Show("It's a Draw!");
                ResetButtons(); // Reset without advancing the round
            }
        }
    }
}
