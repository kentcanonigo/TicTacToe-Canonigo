using System.Collections.Generic;
using System.Drawing;

public static class IconManager {
    // Dictionary mapping IDs to images
    public static readonly Dictionary<int, Image> Icons = new Dictionary<int, Image>
    {
        { 1, TicTacToe_Canonigo.Properties.Resources.icon1 },
        { 2, TicTacToe_Canonigo.Properties.Resources.icon2 },
        { 3, TicTacToe_Canonigo.Properties.Resources.icon3 },
        { 4, TicTacToe_Canonigo.Properties.Resources.icon4 },
        { 5, TicTacToe_Canonigo.Properties.Resources.icon5 },
        { 6, TicTacToe_Canonigo.Properties.Resources.icon6 }
    };
}