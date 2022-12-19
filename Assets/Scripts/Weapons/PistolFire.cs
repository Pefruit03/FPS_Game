using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FiringPistol());
            }
        }
    }
    IEnumerator FiringPistol()
    {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("PistolFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.3f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
