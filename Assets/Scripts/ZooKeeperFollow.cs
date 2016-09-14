using UnityEngine;
using System.Collections;

public class ZooKeeperFollow : MonoBehaviour {

    // Movement speed
    public float speed = 0;

    //Touches Giraffe
    public bool collideZooKeeper;

    // Use this for initialization
    void Update()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(collideZooKeeper == true)
        {

        }
    }
}
