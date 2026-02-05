using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
    public GameObject projectile;  
    public float launchAngle = 45f;  
    public float launchSpeed = 10f;  

    private Rigidbody rb;

    void Start()
    {
        rb = projectile.GetComponent<Rigidbody>();
        float angleInRadians = launchAngle * Mathf.Deg2Rad;
        float horizontalVelocity = launchSpeed * Mathf.Cos(angleInRadians);
        float verticalVelocity = launchSpeed * Mathf.Sin(angleInRadians);
        Vector3 launchVelocity = new Vector3(horizontalVelocity, verticalVelocity, 0);
        rb.AddForce(launchVelocity, ForceMode.VelocityChange);
    }
}
