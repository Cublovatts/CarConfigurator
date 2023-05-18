using UnityEngine;

public class ColorMenuOptionEntry : MenuOptionEntry
{
    private Color _color;

    public ColorMenuOptionEntry(string optionName, int optionPrice, Color color) : base(optionName, optionPrice)
    {
        this._color = color;
    }

    public override void Selected()
    {
        GameObject[] primaryColorObjects = GameObject.FindGameObjectsWithTag("PrimaryColor");
        foreach (GameObject primaryColorObject in primaryColorObjects)
        {
            var renderer = primaryColorObject.GetComponent<Renderer>();
            renderer.material.color = _color;
        }
    }
}
