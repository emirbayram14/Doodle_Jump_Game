using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform doodler;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, doodler.position.y, transform.position.z);
    }
}
