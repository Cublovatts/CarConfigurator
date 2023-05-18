using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PriceCalculator : MonoBehaviour
{
    [SerializeField]
    private TMP_Text priceDisplay;

    private Menu _menu;

    void Start()
    {
        _menu = GameObject.Find("ConfiguratorMenuParent").GetComponent<Menu>();
    }

    void Update()
    {
        UpdateTotalPrice();
    }

    void SetTotal(int total)
    {
        priceDisplay.text = total.ToString();
    }

    void UpdateTotalPrice()
    {
        int total = 0;
        MenuOption[] options = _menu.GetMenuOptions();
        foreach (MenuOption option in options)
        {
            total += option.CurrentOption.OptionPrice;
        }
        SetTotal(total);
    }
}
