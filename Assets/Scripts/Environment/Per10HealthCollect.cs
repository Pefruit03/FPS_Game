using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Per10HealthCollect : MonoBehaviour
{
    public AudioSource eatSound;
    
    void OnTriggerEnter(Collider other)
    {
        if (GlobalHealth.healthValue >= 91)
        {
            GlobalHealth.healthValue = 100;
        }
        else
        {
            GlobalHealth.healthValue += 10;
        }
        eatSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
