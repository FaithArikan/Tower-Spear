using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    [SerializeField] private float turnSpeed;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float height = -17;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y > height)
        {
            transform.Rotate(0, turnSpeed / 100, 0, Space.Self);
            transform.position += new Vector3(0, -moveSpeed / 100, 0) * Time.deltaTime;
        }

    }
}
