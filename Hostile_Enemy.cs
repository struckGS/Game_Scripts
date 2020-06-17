using UnityEngine;

public class Hostile_Enemy : MonoBehaviour
{
    public GameObject respawnMenu;
    public GameObject crosshair;
    public GameObject Gun;
    public GameObject destroyUI;

    private void Start()
    {
        respawnMenu.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
            respawnMenu.SetActive(true);
            crosshair.SetActive(false);
            Gun.SetActive(false);
            destroyUI.SetActive(false);
        }    
    }
}
