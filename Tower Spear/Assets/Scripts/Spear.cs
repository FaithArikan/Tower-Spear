using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public static Spear Instance { get; private set; }
    public Rigidbody rb;
    private int jumpNumber;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        Debug.Log(SpearIns.Instance.spearCount);
        jumpNumber = SpearIns.Instance.spearCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.constraints != RigidbodyConstraints.FreezeAll)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Tower")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        if (col.gameObject.tag == "Plane")
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
