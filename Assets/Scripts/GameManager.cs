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
        
    }

    void OnApplicationQuit()
    {
        GameObject.Find("Player").GetComponent<PlayerManager>().SaveData();
    }

}
