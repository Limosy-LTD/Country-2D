using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCustom : MonoBehaviour
{

    public float alpha = 0.1f;

    void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = alpha;
    }
}
