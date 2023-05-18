using UnityEngine;

public class ObjectBob : MonoBehaviour
{
    public float bobHeight = 0.5f;
    public float bobSpeed = 1.0f;        

    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void Update()
    {
        float newY = originalPosition.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}

