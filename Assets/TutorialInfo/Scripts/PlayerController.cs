using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;

    public float jumpForce = 3;

    public float gravityModifier;

    public bool isOnGround = true; 

    private Animator playerAnim;

    public AudioClip JumpSound;

    public AudioClip CrashSound;
   
   private AudioSource playerAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }
        public ParticleSystem dirtParticle;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameover)
        {            
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            playerAudio.PlayOneShot(JumpSound, 1.0f);
                dirtParticle.Stop();
        }
    }

public bool gameover = false;
public ParticleSystem explosionParticle;

    private void OnCollisionEnter(Collision collision)  {
    if (collision.gameObject.CompareTag("Ground")) {
        isOnGround = true;
        dirtParticle.Play();
    }   else if (collision.gameObject.CompareTag("obstacle")) {
        gameover = true;
        Debug.Log("Game Over!");
        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1);
        explosionParticle.Play();
        dirtParticle.Stop();
        playerAudio.PlayOneShot(CrashSound, 1.0f);
    }

}
}