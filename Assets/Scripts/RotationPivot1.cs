using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using Microsoft.MixedReality.Toolkit.UI.BoundsControlTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPivot1 : MonoBehaviour
{
    //Rotation Pivot Variable.
    public bool rotationOn;
    public float rotationSpeed;
    public GameObject pivotObject;
    private float savedRotationSpeed;
    private float returnSpeed = 1f;
    private float savedReturnSpeed;

    //Check to see if gameobject is pressed.
    private bool isPress;

    public Vector3 startPosition;
    public Vector3 endPosition;
    //private float desiredDuration = 3f;
    //private float elapsedTime;

    //Linked to Shadow GameObject.
    public Shadow shadowScript;

    //On/Off BoundsCOntrol UI
    private BoundsControl boundsControl;

    public bool isHover;
    public HoverSpace hoverScript;
    public Vector3 HoverPosition;

    //Scale to fit glass box. *Every planet will have the same number.*
    public Vector3 scaleResize;
    //Orginal Scale.
    public Vector3 scaleNum;
    private Vector3 savedScaleNum;
    private bool isGrowing;

    void Start()
    {
        //Create boundsControl for gameobject.
        boundsControl = GetComponent<BoundsControl>();

        //Saved Edited varaible of RotationSpeed & ReturnSpeed.
        savedRotationSpeed = rotationSpeed;
        savedReturnSpeed = returnSpeed;

        //Bool to allow Solar System Rotation.
        rotationOn = true;

        //Saved Orginial Scale.
        scaleNum = this.transform.localScale;
        savedScaleNum = scaleNum;
        //Set growing to false.
        isGrowing = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (rotationOn == true)
        {
            //Rotate around the "PivotObject", RotationSpeed degree per second.
            transform.RotateAround(pivotObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);

            //Retrieve data from Shadow Script
            endPosition = shadowScript.Shadpos;

            //Check current positions.
            startPosition = this.transform.position;

            //Check Hover positions.
            HoverPosition = hoverScript.Hoverpos;


            scaleNum = this.transform.localScale;

            if (isPress == true)
            {
                //elapsedTime += Time.deltaTime;
                //float percentageComplete = elapsedTime / desiredDuration;
                //transform.position = Vector3.Lerp(startPosition, percentageComplete);
                transform.position = Vector3.Lerp(startPosition, endPosition, returnSpeed * Time.deltaTime);
            }
            if (isHover == true)
            {
                transform.position = Vector3.Lerp(startPosition, HoverPosition, Time.deltaTime);
            }

            if (isGrowing == true)
            {
                Debug.Log("Going Big");
                transform.localScale = Vector3.Lerp(scaleNum, scaleResize, 10 * Time.deltaTime);
            }
            if (isGrowing == false && scaleNum != savedScaleNum)
            {
                Debug.Log("Going Small");
                transform.localScale = Vector3.Lerp(scaleNum, savedScaleNum, 10 * Time.deltaTime);
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "HoverRay")
        {
            //Debug.Log("Collider On ");

            //Stop Solar System Rotation.
            rotationSpeed= 0;
            returnSpeed = 0;

            isHover = true;

        }
        if (col.gameObject.tag == "Grower")
        {
            isGrowing = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "HoverRay")
        {
            //Debug.Log("Collider Off");

            //Return back to original value.
            rotationSpeed = savedRotationSpeed;
            returnSpeed = savedReturnSpeed;

            //Cancel out Hover Function.
            isHover = false;
            Debug.Log("Going Small");
            transform.localScale = Vector3.Lerp(scaleResize, scaleNum, Time.deltaTime);
        }
        if (col.gameObject.tag == "Grower")
        {
            isGrowing = false;
        }
    }
    public void OnPress()
    {
        //Debug.Log("Grab");
        rotationSpeed = 0;
        returnSpeed = 0;
    }
    public void OffPress()
    {
        //Debug.Log("Not Grab");
        isPress = true;
        rotationOn= true;
        rotationSpeed = savedRotationSpeed;
        returnSpeed = savedReturnSpeed;
    }

    public void OnFocus()
    {
        //Debug.Log("I AM IN FOCUS");

        //Enable BoundControl.
        boundsControl.enabled = true;
    }

    public void OffFocus()
    {
        //Debug.Log("I AM NOT IN FOCUS");

        //Disable BoundControl..
        boundsControl.enabled = false;
    }
}
