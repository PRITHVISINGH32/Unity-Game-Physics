using UnityEngine;
public class TwoObjectsMotion : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public float speed1 = 5.0f;
    public float speed2 = 3.0f;
    private Rigidbody rb1;
    private Rigidbody rb2;
    void Start()
    {
        rb1 = object1.GetComponent<Rigidbody>();
        rb2 = object2.GetComponent<Rigidbody>();
        rb1.velocity = new Vector3(speed1, 0, 0);
        rb2.velocity = new Vector3(speed2, 0, 0); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == object1 || collision.gameObject == object2)
        {
            // Reverse velocities to simulate bounce effect
            rb1.velocity = -rb1.velocity;
            rb2.velocity = -rb2.velocity;

            Debug.Log("Objects collided and bounced off!");
        }
    }
}
