using UnityEngine;

public class LineShifter : MonoBehaviour
{
    private float _age = 0f;
    private float _destroyAfter = 15f;

    void Update()
    {
        gameObject.transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime);

        if (_age > _destroyAfter)
        {
            Destroy(gameObject);
        }

        _age += Time.deltaTime;
    }
}
