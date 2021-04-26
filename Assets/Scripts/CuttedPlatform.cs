using UnityEngine;

public class CuttedPlatform : MonoBehaviour
{
    private readonly float BOTTOM_LIMIT = -4.0f;
    private float MASS_MULTIPLIER;
    private Rigidbody body;

    void Awake()
    {
        body = gameObject.GetComponent<Rigidbody>();
        MASS_MULTIPLIER = body.mass;
    }

    void Start()
    {
        Vector3 scale = gameObject.transform.localScale;
        body.mass = scale.x * scale.y * scale.z * MASS_MULTIPLIER;
    }

    void FixedUpdate()
    {
        if (gameObject.transform.localPosition.y < BOTTOM_LIMIT)
        {
            Destroy(gameObject);
        }
    }
}
