using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCollection : MonoBehaviour
{
    public GameObject player_Gun;
    public GameObject Gun_Collectible;

    // Start is called before the first frame update
    void Start()
    {
        player_Gun.SetActive(false);
        Gun_Collectible.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectible")
        {
            Gun_Collectible.SetActive(false);
            player_Gun.SetActive(true);
            Object.Destroy(Gun_Collectible);
        }    
    }

}
