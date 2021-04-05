using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player_Manager
{
    public class PlayerManager : MonoBehaviour
    {
        public float speed;

        private Rigidbody rb;

        PlayerController playerController = new PlayerController();

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }
        void Update()
        {
            Vector3 playerMove = playerController.Move();
            rb.AddForce(playerMove * speed);
        }
    }
}
