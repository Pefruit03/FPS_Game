using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistolAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmo;
    public AudioSource ammoPickUpSound;
    public GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmo.SetActive(false);
        ammoPickUpSound.Play();
        GlobalAmmo.pistolAmmo += 10;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "BULLETS";
        pickUpDisplay.SetActive(true);
    }
}
