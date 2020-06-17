using UnityEngine;

public class Timed_Spawner : MonoBehaviour
{

    public float elapsedTime = 0.0f;
    
    public GameObject enemyObject;
    public float secondsBetweenSpawn = 2f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0f;            
            Instantiate(enemyObject, transform);
        }
    }

}
