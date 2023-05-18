using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMenuOptionSource : MonoBehaviour
{
    public GameObject Car;
    public GameObject Truck;

    public MenuOption GetModelMenuOption()
    {
        MenuOption menuOption = new MenuOption("Model");

        menuOption.MenuOptionEntries = new List<MenuOptionEntry>
        {
            new ModelMenuOptionEntry("Car", 1000, Car),
            new ModelMenuOptionEntry("Truck", 1500, Truck),
        };

        return menuOption;
    }
}
