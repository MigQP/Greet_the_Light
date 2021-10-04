using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dannycamera : MonoBehaviour
{
	public Transform myCamera;

    public Transform player;
    public Vector3 offset;


    //public float cameraDistance;


	bool _horizontalUp = false;
	bool _horizontalDown = false;

	bool _verticalLeft = false;
	bool _verticalRight = false;

    void Start()
    {

    }

    void FixedUpdate()
    {
        FollowPlayer();

        Vector3 desiredPosition = player.position + offset;
		
	
    }



    void FollowPlayer()
    {
       // transform.position = player.position + player.up * cameraDistance;

    }


}