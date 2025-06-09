using UnityEngine;

public class boundary : MonoBehaviour
{
    
    public logicscript logicScript; // Reference to your main logic script

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the boundary.");
            logicScript.gameOver();
        }
    }
}
