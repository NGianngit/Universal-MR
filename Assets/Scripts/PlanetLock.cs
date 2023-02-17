using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLock : MonoBehaviour
{
    //On/Off Interactable Script.
    private Interactable interactable;
    //On/Off ObjectManipulator Script.
    private ObjectManipulator objectmanipulator;

    public bool isUnlock;

    // Start is called before the first frame update
    void Start()
    {
        //Create Interactable for gameobject.
        interactable = GetComponent<Interactable>();

        //Create ObjectManipulator for gameobject.
        objectmanipulator = GetComponent<ObjectManipulator>();

        isUnlock = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnlock == false)
        {
            interactable.enabled = false;
            objectmanipulator.enabled = false;
        }
        if (isUnlock == true)
        {
            interactable.enabled = true;
            objectmanipulator.enabled = true;
        }
    }
}
