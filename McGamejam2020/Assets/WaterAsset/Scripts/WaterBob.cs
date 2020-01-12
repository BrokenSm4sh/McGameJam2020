using UnityEngine;

public class WaterBob : MonoBehaviour
{
    [SerializeField]
    float height = 0.1f;

    [SerializeField]
    float period = 1;

    private float initialy;
    private float offset;

    private void Awake()
    {
        initialy = transform.position.y;

        offset = 1 - (Random.value * 2);
    }

    private void Update()
    {
        transform.position = new Vector3(transform.position.x, initialy, transform.position.z) - Vector3.up * Mathf.Sin((Time.time + offset) * period) * height;
    }
}
