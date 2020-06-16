using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn_Menu : MonoBehaviour
{
    
    public void Respawn()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

}
