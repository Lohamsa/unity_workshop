
using UnityEngine;

public class Catcher : MonoBehaviour
{
    public float speed = 10f;
    public float limit = 7.5f;

    void Update()
    {
        float input = Input.GetAxisRaw("Horizontal");

        transform.Translate(speed * input * Vector3.right * Time.deltaTime);

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -limit, limit);

        transform.position = pos;
    }
}
