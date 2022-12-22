using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor001E : MonoBehaviour
{
    public GameObject moveableWall;

    private void OnTriggerEnter(Collider other)
    {
        moveableWall.GetComponent<Animator>().enabled = true;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
