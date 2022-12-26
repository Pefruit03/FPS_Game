using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int pistolAmmo;
    public GameObject ammoDisplay;
    public static int currentAmmo;

    void Start()
    {
        currentAmmo = pistolAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        ammoDisplay.GetComponent<Text>().text = "" + pistolAmmo;
    }
}
