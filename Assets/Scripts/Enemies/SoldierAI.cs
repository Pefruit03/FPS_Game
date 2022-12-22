using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer;
    public GameObject soldier;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;
    public int getHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtFlash;

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if (hitTag != "Player")
        {
            soldier.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        soldier.GetComponent<Animator>().Play("FirePistol", -1, 0);
        soldier.GetComponent<Animator>().Play("FirePistol");
        fireSound.Play();
        lookingAtPlayer = true;
        GlobalHealth.healthValue -= 10;
        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        hurtFlash.SetActive(false);
        getHurt = Random.Range(0, 3);
        hurtSound[getHurt].Play();
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
