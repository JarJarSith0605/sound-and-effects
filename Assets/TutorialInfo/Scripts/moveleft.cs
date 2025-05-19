using UnityEngine;

public class moveleft : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript =
        GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public float speed = 30;
    private PlayerController playerControllerScript;

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false) {
            transform.Translate(Vector3.left * Time.deltaTime * speed);}
    }
}
