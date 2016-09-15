using UnityEngine;
using System.Collections;

public class GiraffeJump : MonoBehaviour {

    private gameMaster gm;

    // Jump force
    public float force = 300;

    // Movement speed
    public float speed = 4;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;

        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }

    // Update is called once per frame
    void Update () {
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    // Reset the position of the giraffe when it collides with anything.
    void OnCollisionEnter2D(Collision2D coll)
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    // Destroy the coin when it's collided with along with adding 1 point to the score.
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            gm.points += 1;
        }
    }

}
