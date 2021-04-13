using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : EnemyData
{

    public GameObject raycastPoint = null;

    Vector3 targetPos;
    bool isHit = false;
    // Start is called before the first frame update
    void Start()
    {
        this.LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(raycastPoint.transform.position, raycastPoint.transform.TransformDirection(Vector3.forward), Color.yellow);
    }
    private void FixedUpdate()
    {
        //Raycast();
        //if (isHit)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position,
        //                                             new Vector3(targetPos.x, this.transform.position.y, targetPos.z),
        //                                             0.5f * Time.deltaTime);
        //}
    }

    //private void Raycast()
    //{
    //    RaycastHit hit;
    //    if (Physics.Raycast(raycastPoint.transform.position, raycastPoint.transform.TransformDirection(Vector3.forward), out hit))
    //    {
    //        Debug.DrawRay(raycastPoint.transform.position, raycastPoint.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
    //        isHit = true;
    //        targetPos = hit.transform.position;
    //    }
    //    else
    //    {
    //        isHit = false;
    //    }
    //}
}
