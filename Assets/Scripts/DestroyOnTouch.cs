using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
