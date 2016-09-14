using UnityEngine;
using System.Collections;

public class GiraffeJump : MonoBehaviour {

    // Jump force
    public float force = 300;

    // Movement speed
    public float speed = 4;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update () {

        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        if (transform.position.y == 3.41)
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }
}
