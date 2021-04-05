using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player_Manager
{
    public class PlayerController : MonoBehaviour
    {

        void Update()
        {

        }
        public Vector3 Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            return movement;
        }
    }
}
    
