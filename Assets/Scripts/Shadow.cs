using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    //Rotation Pivot Variable.
    public float rotationSpeed;
    public GameObject pivotObject;

    // Shadow GameObject position.
    public Vector3 Shadpos;

    void Update()
    {
        Shadpos = transform.position;
        //Debug.Log(Shadpos);

        //Rotate around the "PivotObject", RotationSpeed degree per second.
        transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
    }
}
