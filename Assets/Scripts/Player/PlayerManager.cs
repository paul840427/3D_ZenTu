using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player_Manager
{
    public class PlayerManager : PlayerData
    {
        public float speed;

        private Rigidbody rb;

        PlayerController playerController = new PlayerController();

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            this.LoadData();
        }
        void Update()
        {
            Move();
        }
        void Move()
        {
            Vector3 playerMove = playerController.Move();
            rb.AddForce(playerMove * speed);
        }
        void ClickObject()
        {
            
        }
    }
}
