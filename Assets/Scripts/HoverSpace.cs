using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverSpace : MonoBehaviour
{
    // Hovering Space GameObject position.
    public Vector3 Hoverpos;

    void Update()
    {
        Hoverpos = transform.position;
        //Debug.Log(Hoverpos);
    }
}
