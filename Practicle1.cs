using UnityEngine;
public class VectorExample : MonoBehaviour
{
    public float speed = 5.0f;
    private Vector3 targetPosition;
    void Start()
    {

        targetPosition = transform.position;
    }
    void Update()
    {  
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");   
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (movement.magnitude > 1)
        {
            movement = movement.normalized;
        }
        movement = movement * speed * Time.deltaTime;   
        targetPosition += movement;
        transform.position = targetPosition;
        Debug.Log("Current Position: " + transform.position);
        Debug.Log("Movement Vector: " + movement);
        Debug.Log("Target Position: " + targetPosition);
    }
}
