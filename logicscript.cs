using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public GameObject gameOverScreen;

    private void Start()
    {
        if (gameOverScreen == null)
        {
            Debug.LogError("game over screen has not been assigned in the Inspector.");
        }
        if (scoretext == null)
        {
            Debug.LogError("score text has not been assigned in the Inspector");
        }
    }

    [ContextMenu ("increase score")]
    public void addscore(int scoreToAdd = 1)
    {
        playerscore += scoreToAdd;
        if (scoretext != null)
        {
            scoretext.text = playerscore.ToString();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
   public void gameOver()
    {
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }
    }
    private void OnBecameInvisible()
    {
        Debug.Log("gameobject has left the screen");
        gameOver();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        { gameOver(); }
    }
}
