using System.Collections;
using UnityEngine;

public class ModelMenuOptionEntry : MenuOptionEntry
{
    private GameObject _targetModel;

    public ModelMenuOptionEntry(string optionName, int optionPrice, GameObject targetModel) : base(optionName, optionPrice)
    {
        _targetModel = targetModel;
    }

    public override void Selected()
    {
        Car[] cars = GameObject.Find("Cars").GetComponentsInChildren<Car>();
        foreach (Car car in cars)
        {
            car.GetComponent<Car>().MoveOutOfView();
        }

        _targetModel.GetComponent<Car>().MoveIntoView();
    }
}
