using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject MenuOptionPrefab;
    public GameObject PriceDisplayPrefab;

    private List<MenuOption> _menuOptions;

    private float _currentOffset = 0;
    private readonly float _offset = 100;

    void Start()
    {
        // Add new menu options here
        _menuOptions = new List<MenuOption>();
        _menuOptions.Add(GameObject.Find("Cars").GetComponent<ModelMenuOptionSource>().GetModelMenuOption());
        _menuOptions.Add(ColorOptionSource.GetColorMenuOption());
        _menuOptions.Add(PaintOptionSource.GetPaintMenuOption());
        _menuOptions.Add(GameObject.Find("WheelTypeSource").GetComponent<WheelTypeOptionSource>().GetWheelTypeMenuOption());

        foreach (MenuOption menuOption in _menuOptions)
        {
            // Create menu option entry UI and initialise
            GameObject newMenuOptionObject = Instantiate(MenuOptionPrefab, gameObject.transform);
            MenuOption newMenuOption = newMenuOptionObject.GetComponent<MenuOption>();
            newMenuOption.MenuOptionTitle = menuOption.MenuOptionTitle;
            newMenuOption.MenuOptionEntries = menuOption.MenuOptionEntries;
            newMenuOption.transform.position -= new Vector3(0, _currentOffset);
            _currentOffset += _offset;
        }

        GameObject priceDisplay = Instantiate(PriceDisplayPrefab, gameObject.transform);
        priceDisplay.transform.position -= new Vector3(0, _currentOffset);
    }

    public MenuOption[] GetMenuOptions()
    {
        return gameObject.GetComponentsInChildren<MenuOption>();
    }
}
