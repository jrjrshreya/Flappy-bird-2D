using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;       // The pipe prefab to spawn
    public float spawnRate = 2f;  // Time interval between spawns
    private float timer = 0f;     // Timer to track spawn intervals
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // Increment the timer
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0f; // Reset the timer
        }
    }

    // Method to spawn a pipe
    void SpawnPipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint),0), transform.rotation);
    }
}

