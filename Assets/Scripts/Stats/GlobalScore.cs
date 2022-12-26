using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int scoreValue = 0;
    public int internalScore;
    public GameObject finalScore;
    public static int currentScore = 0;

    void Start()
    {
        internalScore = scoreValue;
        currentScore = internalScore;
    }

    void Update()
    {
        //internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue;
        finalScore.GetComponent<Text>().text = "" + scoreValue;
    }
}