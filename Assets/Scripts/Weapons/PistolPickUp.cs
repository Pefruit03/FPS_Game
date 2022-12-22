using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PistolPickUp : MonoBehaviour
{
    public GameObject pistol;
    public GameObject fakePistol;
    public AudioSource gunPickUp;
    public GameObject pickUpDisplay;

    void OnTriggerEnter(Collider other)
    {
        pistol.SetActive(true);
        fakePistol.SetActive(false);
        gunPickUp.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "PISTOL";
        pickUpDisplay.SetActive(true);
    }
}
