using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform tr = gameObject.GetComponent<Transform>();
        tr.position = new Vector3(0, 0, 0);
        Debug.Log( "Start--------");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log( "Update--------");

        Transform tr = gameObject.GetComponent<Transform>();
        Vector3 pos  = tr.position;
        pos.z = pos.z + 0.1f;
        tr.position = pos;
    }
}
