using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class FloorComplete : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject player;
    public GameObject floorTimer;

    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompleteFloor());
        player.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator CompleteFloor()
    {
        fadeOut.SetActive(true);
        GlobalComplete.nextFloor += 1;
        PlayerPrefs.SetInt("SceneToLoad", GlobalComplete.nextFloor);
        PlayerPrefs.SetInt("LivesSaved", GlobalLife.lifeValue);
        PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
        PlayerPrefs.SetInt("AmmoSaved", GlobalAmmo.pistolAmmo);

        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(10);
        GlobalScore.currentScore = GlobalScore.scoreValue;
        //GlobalScore.scoreValue = 0;
        GlobalComplete.enemyCount = 0;
        GlobalComplete.treasureCount = 0;

        SceneManager.LoadScene(GlobalComplete.nextFloor);
    }
}
