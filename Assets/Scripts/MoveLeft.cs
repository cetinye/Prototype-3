using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 30;
    private PlayerContoller playerContollerScript;
    private float outOfBoundX = -10;

    // Start is called before the first frame update
    void Start()
    {
        playerContollerScript = GameObject.Find("Player").GetComponent<PlayerContoller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerContollerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x < outOfBoundX && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
