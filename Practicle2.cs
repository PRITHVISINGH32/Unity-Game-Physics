using UnityEngine;

public class VariableSpeedMotion : MonoBehaviour
{
    public Vector3 initialVelocity = new Vector3(1, 0, 1);
    public Vector3 acceleration = new Vector3(0, 0, 0); 
    public float speedMultiplier = 1.0f;
    public float maxSpeed = 10.0f;
    private Vector3 currentVelocity;
    void Start()
    {
        currentVelocity = initialVelocity;
    }
    void Update()
    {
        currentVelocity += acceleration * Time.deltaTime;
        float currentSpeed = currentVelocity.magnitude * speedMultiplier;
        if (currentSpeed > maxSpeed)
        {
            currentVelocity = currentVelocity.normalized * maxSpeed;
        }
        transform.position += currentVelocity * Time.deltaTime;
        speedMultiplier += 0.1f * Time.deltaTime;
    }
}
