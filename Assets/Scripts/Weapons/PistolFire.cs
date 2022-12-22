using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public AudioSource emptyAmmo;
    public bool isFiring = false;
    public float targetDistance;
    public int damageAmount = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.pistolAmmo < 1)
            {
                emptyAmmo.Play();
            }
            else
            {
                if (isFiring == false)
                {
                    StartCoroutine(FiringPistol());
                }
            }   
        }
    }
    IEnumerator FiringPistol()
    {
        RaycastHit theShot;
        isFiring = true;
        GlobalAmmo.pistolAmmo -= 1;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        theGun.GetComponent<Animator>().Play("PistolFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();

        yield return new WaitForSeconds(0.5f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
