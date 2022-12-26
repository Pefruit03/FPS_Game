using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstKeyA : MonoBehaviour
{
    public GameObject keyUI;
    public GameObject lockedDoorTrigger;
    public GameObject key;

    private void OnTriggerEnter(Collider other)
    {
        keyUI.SetActive(true);
        lockedDoorTrigger.SetActive(true);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        key.SetActive(false);
    }
}
