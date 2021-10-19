using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearIns : MonoBehaviour
{
    public static SpearIns Instance { get; private set;}
    [SerializeField] private Transform spot;
    [SerializeField] private GameObject spear;
    [SerializeField] private Transform InstantiatedSpears;
    [SerializeField] private Camera cam;
    [SerializeField] private float throwSpeed;
    public int spearCountTotal = 10;
    public int spearCount = 0;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(mousePos);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.DrawLine(ray.origin, hit.point, Color.black, 300f);

                if (spearCount != spearCountTotal)
                {
                    GameObject newSpear = Instantiate(spear, InstantiatedSpears) as GameObject;
                    newSpear.transform.position = spot.transform.position;
                    Rigidbody rb = newSpear.GetComponent<Rigidbody>();
                    rb.AddForce(ray.direction.normalized * throwSpeed * 10000 * Time.fixedDeltaTime);
                    spearCount++;
                }
            }
        }
    }

}
