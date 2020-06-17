using UnityEngine;

public class SpawnerDestruction : MonoBehaviour
{
    public GameObject respawnMeanu;
    public GameObject destroyUI;
    public GameObject spawner;
    bool hasReachedSpawner = false;
    public ParticleSystem spawning;
    public ParticleSystem destroyed;
    public GameObject win;
    public GameObject gun;
    public GameObject crosshair;

    private void Start()
    {
        destroyUI.SetActive(false);
        win.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0.3f;
            destroyUI.SetActive(true);
            hasReachedSpawner = true;
        }
    }
    private void Update()
    {

        if (hasReachedSpawner && Input.GetKeyDown("e") && (respawnMeanu.activeSelf == false))
        {
            play();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            spawner.SetActive(false);
            Object.Destroy(respawnMeanu);
            destroyUI.SetActive(false);
            Object.Destroy(gun);
            Object.Destroy(crosshair);
            win.SetActive(true); 
            Time.timeScale = 0f;
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            destroyUI.SetActive(false);
            Time.timeScale = 1f;
            hasReachedSpawner = false;
        }
    }
    private void play()
    {
        spawning.Stop();
        destroyed.Play();
    }
}
