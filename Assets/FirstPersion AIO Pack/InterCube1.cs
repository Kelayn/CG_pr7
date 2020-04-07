using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube1 : MonoBehaviour
{
    public GameObject TargetGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TargetGameObject.GetComponent<Rigidbody>().AddForce(0, 100, 0);
        }
    }
}
