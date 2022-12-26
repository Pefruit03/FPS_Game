using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public GameObject healthDisplay;
    public static int healthValue;
    public int internalHealth;
    public GameObject hp100;
    public GameObject hp70;
    public GameObject hp50;
    public GameObject hp20;

    void Start()
    {
        healthValue = 100;
    }

    void Update()
    {
        if (healthValue <= 0)
        {
            SceneManager.LoadScene(1);
            GlobalScore.scoreValue = GlobalScore.currentScore;
            GlobalAmmo.pistolAmmo = GlobalAmmo.currentAmmo;
        }
        internalHealth = healthValue;
        healthDisplay.GetComponent<Text>().text = "" + healthValue + "%";

        if (healthValue > 70)
        {
            hp100.SetActive(true);
            hp70.SetActive(false);
            hp50.SetActive(false);
            hp20.SetActive(false);
        }

        if (healthValue >= 50 && healthValue < 69)
        {
            hp100.SetActive(false);
            hp70.SetActive(true);
            hp50.SetActive(false);
            hp20.SetActive(false);
        }

        if (healthValue >= 20 && healthValue < 49)
        {
            hp100.SetActive(false);
            hp70.SetActive(false);
            hp50.SetActive(true);
            hp20.SetActive(false);
        }

        if (healthValue < 20)
        {
            hp100.SetActive(false);
            hp70.SetActive(false);
            hp50.SetActive(false);
            hp20.SetActive(true);
        }
    }
}
