using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Canonigo { // Singleton Pattern kay kapoy
    internal class Player {
        private static Player instance = null;

        private Player() {
            PlayerName = "Juan Dela Cruz";
            Score = 0;
        }

        public static Player Instance {
            get {
                if (instance == null) {
                    instance = new Player();
                }
                return instance;
            }
        }

        // Public properties to hold global values
        public string PlayerName { get; set; }

        public int Score { get; set; }
    }
}
