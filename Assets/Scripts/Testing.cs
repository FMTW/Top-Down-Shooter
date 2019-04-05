using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.0f, 0.0f, speed) ;
    }
}
