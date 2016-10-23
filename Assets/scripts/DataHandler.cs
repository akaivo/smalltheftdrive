using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

public class DataHandler : MonoBehaviour
{
    public int money;
    public int levelsCompleted;

	
    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.money = money;
        data.levelsCompleted = levelsCompleted;
        bf.Serialize(file,data);
        file.Close();
    }

    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

            PlayerData data = (PlayerData) bf.Deserialize(file);
            file.Close();
            money = data.money;
            levelsCompleted = data.levelsCompleted;


        }
        else
        {
            money = 0;
            levelsCompleted = 0;
        }
    }
   
}
[Serializable]
class PlayerData
{
    public int money;
    public int levelsCompleted; 
}
