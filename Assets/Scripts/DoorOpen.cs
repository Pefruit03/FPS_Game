using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject door;
    public AudioSource doorFX;

    private void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        door.GetComponent<Animator>().Play("DoorOpen");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        doorFX.Play();
        door.GetComponent<Animator>().Play("DoorClose");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
