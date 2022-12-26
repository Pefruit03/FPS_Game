using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ToMenu());
    }

    IEnumerator ToMenu()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene(2);
    }
}
