using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float strength;
    public logicScript logic;
    public bool birdIsAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myrigidbody.linearVelocity = Vector2.up * strength;
        }
        if (transform.position.y > 12 || transform.position.y < -12 ){
            logic.gameOver();
            birdIsAlive=false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
