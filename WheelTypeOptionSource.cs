using System.Collections.Generic;
using UnityEngine;

public class WheelTypeOptionSource : MonoBehaviour
{
    public Texture2D NormalTexture;
    public Texture2D BlackTexture;

    public MenuOption GetWheelTypeMenuOption()
    {
        MenuOption menuOption = new MenuOption("Wheel Type");

        menuOption.MenuOptionEntries = new List<MenuOptionEntry>
        {
            new WheelTypeMenuOptionEntry("Normal", 300, NormalTexture),
            new WheelTypeMenuOptionEntry("Black", 800, BlackTexture),
        };

        return menuOption;
    }
}
