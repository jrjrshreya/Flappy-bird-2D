using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // Reference to Rigidbody2D component
    public float flapStrength; // Strength of the bird's flap
    public logicscript logic;       // Reference to LogicScript
    public bool birdIsAlive = true;
    void Start()
    {
        // Find the LogicScript attached to the GameObject with the "logic" tag
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space)== true && birdIsAlive == true)
        {
            // Apply upward velocity to the Rigidbody2D
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }

    // Detect collision with other objects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Call the game over method in LogicScript
        logic.gameOver();
        birdIsAlive = false;
    }
}


