using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmo;
    public AudioSource ammoPickUpSound;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmo.SetActive(false);
        ammoPickUpSound.Play();
        GlobalAmmo.pistolAmmo += 10;
    }
}
