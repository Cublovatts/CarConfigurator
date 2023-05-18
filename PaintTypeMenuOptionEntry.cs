using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintTypeMenuOptionEntry : MenuOptionEntry
{
    private float _smoothness;

    public PaintTypeMenuOptionEntry(string optionName, int optionPrice, float smoothness) : base(optionName, optionPrice)
    {
        this._smoothness = smoothness;
    }

    public override void Selected()
    {
        GameObject[] primaryColorObjects = GameObject.FindGameObjectsWithTag("PrimaryColor");
        foreach (GameObject primaryColorObject in primaryColorObjects)
        {
            var renderer = primaryColorObject.GetComponent<Renderer>();
            renderer.material.SetFloat("_Smoothness", _smoothness);
        }
    }
}
