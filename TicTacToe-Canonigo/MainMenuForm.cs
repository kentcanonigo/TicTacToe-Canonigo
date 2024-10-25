namespace TicTacToe_Canonigo {
    public partial class mainMenuForm : Form {

        // Step 1: Static instance
        private static mainMenuForm instance;

        // Step 2: Public static property to access the instance
        public static mainMenuForm Instance {
            get {
                // If the instance is not created, create it
                if (instance == null || instance.IsDisposed) {
                    instance = new mainMenuForm();
                }
                return instance;
            }
        }

        public mainMenuForm() {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e) {
            this.Hide();
            // Open the GameForm modally (with ShowDialog)
            PreGameForm preGameForm = new PreGameForm();
            // Show the GameForm
            preGameForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e) {
            // Close the application when the Exit button is clicked
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e) {
            // Hide the main menu form
            this.Hide();

            // Open the HelpForm modally
            HelpForm helpForm = new HelpForm();

            // Show the HelpForm and wait for it to close
            helpForm.ShowDialog();

            // After HelpForm is closed, show the main menu form again
            this.Show();
        }

        private void aboutButton_Click(object sender, EventArgs e) {
            // Hide the main menu form
            this.Hide();

            // Open the AboutForm modally
            AboutForm aboutForm = new AboutForm();

            // Show the AboutForm and wait for it to close
            aboutForm.ShowDialog();

            // After AboutForm is closed, show the main menu form again
            this.Show();
        }

        private void mainMenuForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
