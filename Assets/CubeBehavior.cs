using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{

    public void OnFocus()
    {
        Debug.Log("I AM THE ZACK (IN FOCUS)");
    }
    
    public void OffFocus()
    {
        Debug.Log("IM NOT DA ZACK (OFF FOCUS)");
    }

    public void OnPress()
    {
        Debug.Log("U HAVE TOUCHED THE ZACK");
    }

    public void OnRelease()
    {
        Debug.Log("STOPPED TOUCHING THE ZACK");
    }

    public void OnGrab()
    {
        Debug.Log("GRABBED THE ZACK");
       
    }
}
