using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Canonigo { // Singleton Pattern kay kapoy
    internal class Player {
        private static Player instance = null;
        private static Player instance2 = null;

        private Player(string playerName, int defaultIcon) {
            PlayerName = playerName;
            PlayerIcon = IconManager.Icons[defaultIcon];
        }

        public static Player Instance {
            get {
                if (instance == null) {
                    instance = new Player("", 1);
                }
                return instance;
            }
        }

        public static Player Instance2 {
            get {
                if (instance2 == null) {
                    instance2 = new Player("", 2);
                }
                return instance2;
            }
        }

        // Public properties to hold global values
        public string PlayerName { get; set; }
        public int PlayerIconId { get; set; }
        public Image PlayerIcon { get; set; }
    }
}
