using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopEnemyPath : MonoBehaviour {
    public GameObject[] _bienemys;
    public FollowPath _following;




    // Use this for initialization
    void Start()
    {
        _bienemys = GameObject.FindGameObjectsWithTag("bienemy");
        _following = GetComponent<FollowPath>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            _following.enabled = !_following.enabled;
        }
    }
}
