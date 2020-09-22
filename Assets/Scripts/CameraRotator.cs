using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public Transform target;
    public float speed;

    public float angle = 30f;
    private Vector3 targetPos;

    void Start()
    {
        Transform target = GameObject.Find("VFXCentor").transform;
        transform.LookAt(target);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = transform.TransformDirection(Vector3.up);
        transform.RotateAround(target.position, axis, speed * Time.deltaTime);
    }
}
