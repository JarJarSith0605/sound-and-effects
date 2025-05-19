using UnityEngine;

public class soawnmanager : MonoBehaviour
{
    public GameObject[] Obstacleprefab;

    private int index; 

    private float startDelay = 2;

    private float repeatRate = 2;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
         index = Random.Range(0, Obstacleprefab.Length);
         Instantiate (Obstacleprefab[index], spawnPos, Obstacleprefab[index].transform.rotation);
    }
}
