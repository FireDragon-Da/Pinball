using UnityEngine;

public class Spring : MonoBehaviour
{
    public Rigidbody2D ball;  
    public float launchPower; 
    private bool isCharging = false;
    private float chargePower = 0f;
    public float maxCharge;  
    public float chargeRate;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            isCharging = true;
            chargePower += chargeRate * Time.deltaTime;
            chargePower = Mathf.Clamp(chargePower, 0, maxCharge);
        }

        if (Input.GetKeyUp(KeyCode.Space) && isCharging) 
        {
            LaunchBall();
            isCharging = false;
            chargePower = 0f;
        }
    }

    void LaunchBall()
    {
        if (ball != null)
        {
            ball.linearVelocity = Vector2.up * chargePower; 
        }
    }
}
