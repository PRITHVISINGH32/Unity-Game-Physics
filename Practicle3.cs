using UnityEngine;

public class BallMotion : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 initialForce = new Vector3(1.0f, 0.0f, 0.0f); 
        rb.AddForce(initialForce * speed, ForceMode.VelocityChange);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Vector3 reflectedVelocity = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflectedVelocity;

            Debug.Log("Ball collided with the wall and bounced back!");
        }
    }
}
