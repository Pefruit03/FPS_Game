using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickUp : MonoBehaviour
{
    public GameObject pistol;
    public GameObject fakePistol;
    public AudioSource gunPickUp;

    void OnTriggerEnter(Collider other)
    {
        pistol.SetActive(true);
        fakePistol.SetActive(false);
        gunPickUp.Play();
    }
}
