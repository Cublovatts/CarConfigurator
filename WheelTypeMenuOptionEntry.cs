using UnityEngine;

public class WheelTypeMenuOptionEntry : MenuOptionEntry
{
    private Texture2D _textureFileName;

    public WheelTypeMenuOptionEntry(string optionName, int optionPrice, Texture2D fileName) : base(optionName, optionPrice)
    {
        _textureFileName = fileName;
    }

    public override void Selected()
    {
        GameObject[] wheels = GameObject.FindGameObjectsWithTag("Wheel");
        foreach (GameObject wheel in wheels) 
        {
            Debug.Log("Setting wheel texture");
            wheel.transform.GetChild(0).GetComponent<Renderer>().material.mainTexture = _textureFileName;
        }
    }
}
