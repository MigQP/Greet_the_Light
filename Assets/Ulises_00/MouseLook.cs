using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public string HorizontalAxis = "RHorizontal";
    public string VerticalAxis = "RVertical";
    public float lookSpeed = 2.0f;
    public bool useController;

    public Transform target;

    public GameObject cube;
    Vector3 mousePos;
        // Update is called once per frame

    void Start()
    {
        // transform.rotation = Quaternion.Euler(0, 0, 0);



    }
    void Update()
    {
        controllers();
    }
    void controllers()
    {
        if (!useController)
        {
            float h = lookSpeed * Input.GetAxis("Mouse X");
            transform.Rotate(0, h, 0);
        }

        if (useController)
        {
        
        }
        Vector3 playerDirection = new Vector3(Input.GetAxis("RHorizontal"), 0, Input.GetAxis("RVertical")).normalized;
        if (playerDirection.sqrMagnitude > 0)
            target.localRotation = Quaternion.LookRotation(playerDirection, Vector3.up);

    }



}
