using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // 1. kodlama kısmı
    
    public Rigidbody rb;
    // Kendim rb olarak kısaltma belirttim
    
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    
    // Float number icin f ekle

    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
