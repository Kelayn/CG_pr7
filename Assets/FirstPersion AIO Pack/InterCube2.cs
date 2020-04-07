using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterCube2 : MonoBehaviour
{
    public GameObject TargetGameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TargetGameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
