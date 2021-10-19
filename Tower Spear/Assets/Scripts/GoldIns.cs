using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldIns : MonoBehaviour
{
    [SerializeField] private float radius = 5f;
    [SerializeField] GameObject prefab;
    [SerializeField] Transform golds;
    [SerializeField] private int numberOfObjectsMin = 1;
    [SerializeField] private int numberOfObjectsMax = 20;
    [SerializeField] private int heightMin = 1;
    [SerializeField] private int heightMax = 20;
    [SerializeField] private int spawnNumb;


    private void Start()
    {
        for (int spawnNumb = 0; spawnNumb < 5; spawnNumb++)
        {
            for (int i = 0; i < 20; i++)
            {
                float angle = i * Mathf.PI * 2 / Random.Range(numberOfObjectsMin, numberOfObjectsMax);
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;
                Vector3 pos = transform.position + new Vector3(x, Random.Range(heightMin, heightMax), z);
                float angleDegrees = -angle * Mathf.Rad2Deg;
                Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
                Instantiate(prefab, pos, rot, golds);
            }
        }

    }
}
