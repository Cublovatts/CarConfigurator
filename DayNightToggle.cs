using UnityEngine;

public class DayNightToggle : MonoBehaviour
{
    public Light DirectionalLight;

    public void OnToggle(bool state)
    {
        if (!state)
        {
            DirectionalLight.enabled = false;
        } else
        {
            DirectionalLight.enabled = true;
        }
    }
}
