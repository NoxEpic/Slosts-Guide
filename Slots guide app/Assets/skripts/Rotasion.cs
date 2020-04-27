using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotasion : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.LookAt(target, Vector3.left);
    }
}
