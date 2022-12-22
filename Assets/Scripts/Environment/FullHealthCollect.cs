using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealthCollect : MonoBehaviour
{
    public AudioSource eatSound;
    
    void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;
        eatSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
