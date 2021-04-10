using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player_Manager;

public class GameManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            Debug.Log(hit.collider.name);

        }
    }

    void OnApplicationQuit()
    {
        GameObject.Find("Player").GetComponent<PlayerManager>().SaveData();
    }

}
