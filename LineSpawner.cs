using UnityEngine;

public class LineSpawner : MonoBehaviour
{
    public GameObject LinePrefab;

    private float _time = 0.0f;
    private readonly float _lineInterval = 3.0f;

    void Update()
    {
        _time += Time.deltaTime;

        if (_time > _lineInterval)
        {
            _time = 0f;
            Instantiate(LinePrefab, gameObject.transform);
        }
    }
}
