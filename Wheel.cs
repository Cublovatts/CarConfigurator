using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(300 * Time.deltaTime, 0, 0);
    }
}
