using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    public Rigidbody rb;
    public GameManager gameManager;
    public float ForwardForce = 2000f;
    public float SidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce((-ForwardForce)*Time.deltaTime,0,0);  
        if(Input.GetKey("d")){
            rb.AddForce(0, 0, SidewayForce * Time.deltaTime, ForceMode.Force);
        }

        if(Input.GetKey("a")){
            rb.AddForce(0, 0, -SidewayForce * Time.deltaTime, ForceMode.Force);
        }
        if(rb.position.y < -2){
            gameManager.endGame();
        }
    }
}
