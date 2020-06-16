using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform parent;
    public float angle;
    void Update()
    {
        transform.RotateAround(parent.position, Vector3.up, angle * Time.deltaTime);
    }

}
