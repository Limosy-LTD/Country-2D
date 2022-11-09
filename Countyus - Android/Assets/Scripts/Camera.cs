using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject WorldScroll;

    public void CenterCam()
    {
        WorldScroll.transform.position = new Vector3(0, 0, 0);
    }
}
