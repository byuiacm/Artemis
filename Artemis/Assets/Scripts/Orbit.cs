using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform center;
    public Vector3 axis = Vector3.up;
    public float radius = 2f;
    public float orbitSpeed = 45f;
    public float rotateSpeed = 90f;

    void Start()
    {
        transform.position = (transform.position - center.position).normalized * radius + center.position;
    }

    void Update()
    {
        OrbitMovement();
    }

    void OrbitMovement()
    {
        var initRotation = transform.rotation * Quaternion.Euler(0, rotateSpeed * Time.deltaTime, 0);
        transform.RotateAround(center.position, axis, orbitSpeed * Time.deltaTime);
        transform.rotation = initRotation;
    }
}
