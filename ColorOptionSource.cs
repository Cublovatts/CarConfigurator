using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorOptionSource 
{
    public static MenuOption GetColorMenuOption()
    {
        MenuOption option = new MenuOption("Color");
        // Add new color options here
        option.MenuOptionEntries = new List<MenuOptionEntry>
        {
            new ColorMenuOptionEntry("Red", 500, Color.red),
            new ColorMenuOptionEntry("Blue", 600, Color.blue),
            new ColorMenuOptionEntry("Black", 600, Color.black),
            new ColorMenuOptionEntry("Gray", 800, Color.gray),
            new ColorMenuOptionEntry("Yellow", 900, Color.yellow)
        };

        return option;
    }
}
