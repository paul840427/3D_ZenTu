using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    public Property enemyStatus = new Property();
    // Start is called before the first frame update
    void Start()
    {
        enemyStatus.Level = 10;
        enemyStatus.HP = 100;
        enemyStatus.MP = 50;
        enemyStatus.EXP = 0;
        enemyStatus.ATK = 10;
        enemyStatus.MATK = 10;
        enemyStatus.STR = 5;
        enemyStatus.INT = 5;
        enemyStatus.VIT = 5;
        enemyStatus.LUK = 5;

        SaveData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveData()
    {
        string saveString = JsonUtility.ToJson(enemyStatus);

        StreamWriter file = new StreamWriter(System.IO.Path.Combine("Assets/GameJSONData", "Enemy1.json"));

        file.Write(saveString);

        file.Close();
    }
    public void LoadData()
    {

        StreamReader fileReader = new StreamReader(System.IO.Path.Combine("Assets/GameJSONData", "Enemy1.json"));

        string stringJson = fileReader.ReadToEnd();

        fileReader.Close();

        enemyStatus = JsonUtility.FromJson<Property>(stringJson);

        print("Level:" + enemyStatus.Level);

    }
}
