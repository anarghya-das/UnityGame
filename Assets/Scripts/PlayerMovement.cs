using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sideForce;
    public bool leftKey = false;
    public bool rightKey = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// 
    void Update()
    {
        leftKey = Input.GetKey("right");
        rightKey = Input.GetKey("left");
    }

    // Update is called once per frame
    void FixedUpdate() //For physics calculations
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (leftKey)
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rightKey)
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f){
            FindObjectOfType<GameManager>().GameOver();
        }

    }
}
