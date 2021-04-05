using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player_Manager
{
   public class PlayerMove : MonoBehaviour
    {
        public void playerController(Transform transform, float moveSpeed, float rotateSpeed)
        {
            if (Input.GetKey(KeyCode.W)) { transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); }
            if (Input.GetKey(KeyCode.S)) { transform.Translate(-Vector3.forward * Time.deltaTime * moveSpeed); }
            if (Input.GetKey(KeyCode.A)) { transform.Rotate(-Vector3.up * Time.deltaTime * rotateSpeed); }
            if (Input.GetKey(KeyCode.D)) { transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed); }
        }
    }
}