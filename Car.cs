using System.Collections;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject TargetViewPosition;
    public GameObject OutOfViewPosition;

    private float _speed = 5f;
    private bool _isMoving = false;

    public void MoveOutOfView()
    {
        gameObject.transform.position = OutOfViewPosition.transform.position;
        _isMoving = false;
    }
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, TargetViewPosition.transform.position) > 0.01f && _isMoving)
        {
            var step = Time.deltaTime * _speed;
            transform.position = Vector3.MoveTowards(transform.position, TargetViewPosition.transform.position, step);
        }
    }

    public void MoveIntoView()
    {
        _isMoving = true;
    }
}
