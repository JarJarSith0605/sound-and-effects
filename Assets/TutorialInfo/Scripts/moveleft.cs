using UnityEngine;

public class moveleft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private float speed = 30;
    private PlayerController PlayerControllerScript;
    private float leftBound = -15;

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameover == false) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);}
        
        if (transform.position.x < leftBound && gameObject.CompareTag("obstacle")){
            Destroy (gameObject); }}}
