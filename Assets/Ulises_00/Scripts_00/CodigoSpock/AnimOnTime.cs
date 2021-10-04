using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CompleteAnimation
{
    public class AnimOnTime : MonoBehaviour
    {

        private Animator animt;

        // Use this for initialization
        void Start()
        {
            animt = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void _animation()
        {
            animt.SetBool("isWalking", true);
        }
    }
}
