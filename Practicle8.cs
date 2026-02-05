using UnityEngine;

public class MobileCollision : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("StaticObject"))
        {
            Debug.Log("Collision detected with static object!");
        }
    }
}
