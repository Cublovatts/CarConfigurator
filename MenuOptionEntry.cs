using UnityEngine;

public class MenuOptionEntry
{
    public string OptionName;
    public int OptionPrice;

    public MenuOptionEntry(string optionName, int optionPrice)
    {
        this.OptionName = optionName;
        this.OptionPrice = optionPrice;
    }

    public virtual void Selected()
    {
        Debug.Log("Hook here");
    }
}
   
