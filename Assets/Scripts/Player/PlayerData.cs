using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    Property playerStatus = new Property();
    // Start is called before the first frame update
     void Start()
    {
        playerStatus.Level = 10;
        playerStatus.HP = 100;
        playerStatus.MP = 50;
        playerStatus.EXP = 0;
        playerStatus.ATK = 10;
        playerStatus.MATK = 10;
        playerStatus.STR = 5;
        playerStatus.INT = 5;
        playerStatus.VIT = 5;
        playerStatus.LUK = 5;

        SaveData();
    }
    public void SaveData()
    {
        string saveString = JsonUtility.ToJson(playerStatus);

        StreamWriter file = new StreamWriter(System.IO.Path.Combine("Assets/GameJSONData", "Player1.json"));

        file.Write(saveString);

        file.Close();
    }
    public void LoadData()
    {

        StreamReader fileReader = new StreamReader(System.IO.Path.Combine("Assets/GameJSONData", "Player1.json"));

        string stringJson = fileReader.ReadToEnd();

        fileReader.Close();

        playerStatus = JsonUtility.FromJson<Property>(stringJson);

        print("Level:" + playerStatus.Level);

    }
}
