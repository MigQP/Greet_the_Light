using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aeon : MonoBehaviour
{

    //VARIABLES//***************

    public Rigidbody myRigidBody;
    public Transform[] hoverPoints;

    float[] distanceToSurface = new float[4];
    float[] hoverPointError = new float[4];
    bool[] hoverDetectsTrack = new bool[4];
    bool[] numberOfDetections = new bool[4];
    int numberOfDetectionsInt = 0;
    public bool isDetectingTrack;

    public float trackDetectionHeight = 60.0f;
    public float artificialGravityForce = 10.0f;
    public float hoverDesiredHeight = 20.0f;
    public float maxHoverForce = 60.0f;
    public float newDrag = 10.0f;
    public float newDragFlying = 10.0f;
    public float hoverForceIncreaseSpeed = 10.0f;

    //MAIN FUNCTIONS//***************

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        TrackDetectionBoolSet();
        hoversTrackDetection();
        drawHovers();
    }

    void FixedUpdate()
    {
        artificialGravity();
    }

    //MISC FUNCTIONS//***************

    void TrackDetectionBoolSet() // Update()
    {
        if (numberOfDetectionsInt == 0)
        {
            isDetectingTrack = true;
        }
        else
        {
            isDetectingTrack = false;
        }

    }

    void hoversTrackDetection() // Update()
    {
        for (int i = 0; i < 4; i++)
        {
            hoverDetectTrack(hoverPoints[i], i);
        }
    }
    void hoverDetectTrack(Transform hoverPoint, int hoverNumber) // hoversTrackDetection()
    {
        RaycastHit hit;
        if (Physics.Raycast(hoverPoint.position, -hoverPoint.up, out hit, trackDetectionHeight, LayerMask.GetMask("Water")))
        {
            if (numberOfDetections[hoverNumber])
            {
                numberOfDetectionsInt += 1;
                numberOfDetections[hoverNumber] = false;
            }

            if (isDetectingTrack)
            {
                distanceToSurface[hoverNumber] = hit.distance;
                hoverDetectsTrack[hoverNumber] = true;
                hoverPointError[hoverNumber] = hit.distance - hoverDesiredHeight;

                myRigidBody.useGravity = false;
                myRigidBody.drag = newDrag;
            }
        }
        else
        {
            if (!numberOfDetections[hoverNumber])
            {
                numberOfDetectionsInt -= 1;
                numberOfDetections[hoverNumber] = true;
            }

            hoverDetectsTrack[hoverNumber] = false;
            myRigidBody.useGravity = true;
            myRigidBody.drag = newDragFlying;
        }
        if (Physics.Raycast(hoverPoint.position, -hoverPoint.up, out hit, trackDetectionHeight, LayerMask.GetMask("Limites")))
        {
            isDetectingTrack = false;
        }
    }
    void drawHovers() // Update()
    {
        for (int i = 0; i < 4; i++)
        {
            Debug.DrawRay(hoverPoints[i].position, -hoverPoints[i].up * trackDetectionHeight, Color.green);
        }
    }

    void artificialGravity() // Fixedupdate()
    {
        for (int i = 0; i < 4; i++)
        {
            hoversGravity(hoverPoints[i], i);
        }
    }
    void hoversGravity(Transform hoverPoint, int hoverNumber) // artificialGravity()
    {
        if (numberOfDetectionsInt == 0)
        {
            myRigidBody.AddForceAtPosition(
                (-hoverPoint.up) * (artificialGravityForce) * (hoverPointError[hoverNumber])
                , hoverPoint.transform.position
                , ForceMode.Acceleration);
            hoverForceBehaviour();
        }
        else
        {
            artificialGravityForce = 0;
        }
    }
    void hoverForceBehaviour() // hoversGravity()
    {
        artificialGravityForce += hoverForceIncreaseSpeed * Time.fixedDeltaTime;
        if (artificialGravityForce > maxHoverForce)
        {
            artificialGravityForce = maxHoverForce;
        }
    }
}