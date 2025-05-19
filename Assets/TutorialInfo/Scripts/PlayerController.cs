using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float jumpForce = 3;

    public bool isOnGround = true; 
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {            
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

public bool gameover = false;

    private void OnCollisionEnter(Collision collision)  {
    if (collision.gameObject.CompareTag("Ground")) {
        isOnGround = true;
    }   else if (collision.gameObject.CompareTag("obstacle")) {
        gameover = true;
        Debug.Log("Game Over!");
    }

}
}