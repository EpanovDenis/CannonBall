using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject CilinderR;
    [SerializeField, Range(0, 1000)] private float speed = 100.0f;
    private bool flag = false;

    private void Update()
    {
        RotateCilinder();
        if (flag == true)
        {
            RotateCilinder();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            flag = true;
        }
    }

    private void RotateCilinder()
    {
        CilinderR.transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
