using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOption : MonoBehaviour
{
    public string MenuOptionTitle;
    public List<MenuOptionEntry> MenuOptionEntries;
    public MenuOptionEntry CurrentOption;

    [SerializeField]
    private TMP_Text optionTitle;
    [SerializeField]
    private TMP_Text optionDetails;

    private int _currentOptionPointer = 0;
    
    public MenuOption(string menuOptionTitle)
    {
        this.MenuOptionTitle = menuOptionTitle;
    }

    public MenuOption(MenuOption menuOption)
    {
        this.MenuOptionTitle = menuOption.MenuOptionTitle;
        this.MenuOptionEntries = menuOption.MenuOptionEntries;
    }
    
    void Start()
    {
        UpdateDetailsPrice();
    }

    void Update()
    {
        SetOptionTitle();
    }

    void SetOptionTitle()
    {
        optionTitle.text = MenuOptionTitle;
    }

    void SetOptionDetails(MenuOptionEntry menuOptionEntry)
    {
        optionDetails.text = menuOptionEntry.OptionName + " -  £" + menuOptionEntry.OptionPrice.ToString();
    }

    public void PreviousOption()
    {
        _currentOptionPointer--;
        if (_currentOptionPointer < 0)
        {
            _currentOptionPointer = MenuOptionEntries.Count - 1;
        }

        UpdateDetailsPrice();
    }

    public void NextOption()
    {
        _currentOptionPointer++;
        if (_currentOptionPointer > MenuOptionEntries.Count - 1)
        {
            _currentOptionPointer = 0;
        }

        UpdateDetailsPrice();
    }

    void UpdateDetailsPrice()
    {
        MenuOptionEntry current = MenuOptionEntries[_currentOptionPointer];
        CurrentOption = current;
        SetOptionDetails(current);
        current.Selected();
    }
}
