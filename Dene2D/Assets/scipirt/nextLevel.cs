using UnityEngine.SceneManagement;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
