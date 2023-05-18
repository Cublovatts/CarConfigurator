using System.Collections.Generic;
using UnityEngine;

public class PaintOptionSource : MonoBehaviour
{
    public static MenuOption GetPaintMenuOption()
    {
        MenuOption menuOption = new MenuOption("Paint Type");
        menuOption.MenuOptionEntries = new List<MenuOptionEntry>
        {
            new PaintTypeMenuOptionEntry("Glossy", 300, 1f),
            new PaintTypeMenuOptionEntry("Normal", 200, 0.5f),
            new PaintTypeMenuOptionEntry("Matte", 500, 0f)
        };

        return menuOption;
    }
}
