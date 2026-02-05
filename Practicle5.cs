using UnityEngine;

public class GravityEffect : MonoBehaviour
{
    public GameObject fallingObject;
    private Rigidbody rb;

    void Start()
    {
        rb = fallingObject.GetComponent<Rigidbody>();
        rb.useGravity = true;
        Physics.gravity = new Vector3(0, -9.81f, 0); 
    }

    void Update()
    {
        Debug.Log("Falling velocity: " + rb.velocity);
    }
}
