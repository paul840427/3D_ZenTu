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
        public Dictionary<string, Vector3> MouseRay()
        {
            Dictionary<string, Vector3> hitObject = new Dictionary<string, Vector3>();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                switch (hit.collider.name)
                {
                    case "Plane":
                        return hitObject;
                        break;
                    case "Enemy":
                        return hitObject;
                        break;
                    default:
                        return hitObject;
                        break;
                }
            }
            else
                return hitObject;
        }
        //public GameObject mouseClick()
        //{
        //    if (Input.GetMouseButtonDown(1))
        //    {

        //    }
        //    return 
        //}
    }
}
    
