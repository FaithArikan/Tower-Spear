using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Character")
        {
            Destroy(gameObject);
            ScoreManager.theScore += 100;
        }
    }
}
