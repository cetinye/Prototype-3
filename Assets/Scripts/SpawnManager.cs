using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(26, 0, 0);
    public float startDelay = 2;
    public float repeatRate = 2;
    private PlayerContoller playerContollerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerContollerScript = GameObject.Find("Player").GetComponent<PlayerContoller>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerContollerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
        
    }
}
