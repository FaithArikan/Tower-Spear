using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE:" + theScore;
    }
}