using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private float maxDistanceX = 2f;
    [SerializeField] private float maxDistanceY = 2f;

    void Update()
    {
        float xDistance = Spear.Instance.transform.position.x - transform.position.x;
        float yDistance = Spear.Instance.transform.position.y - transform.position.y;

        for (int spearCount = 0; spearCount < SpearIns.Instance.spearCountTotal; spearCount++)
        {
            if (Spear.Instance.rb.constraints == RigidbodyConstraints.FreezeAll)
            {
                if (xDistance < Mathf.Abs(maxDistanceX) && yDistance < Mathf.Abs(maxDistanceY))
                {
                    transform.position = Vector3.SmoothDamp(transform.position, Spear.Instance.transform.position, 
                        ref velocity, moveSpeed);
                }
            }
        }
    }
}
