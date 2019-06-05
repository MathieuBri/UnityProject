using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;

public class LeaderMenu : MonoBehaviour
{
    public List<Leaderboard> leaderboard = new List<Leaderboard>();
    void Start()
    {
        //SaveLeaderboard();

        leaderboard = LoadLeaderboard();

        if (leaderboard != null)
        {
            GameObject.Find("FirstTime").GetComponent<TextMeshProUGUI>().text = leaderboard[0].time.ToString();
            GameObject.Find("SecondTime").GetComponent<TextMeshProUGUI>().text = leaderboard[1].time.ToString();
            GameObject.Find("ThirdTime").GetComponent<TextMeshProUGUI>().text = leaderboard[2].time.ToString();
        }
    }

    public List<Leaderboard> LoadLeaderboard()
    {
        if (File.Exists(Application.persistentDataPath + "/leaderboard.dat"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/leaderboard.dat", FileMode.Open);
            //file.Close();

            return formatter.Deserialize(file) as List<Leaderboard>;
        }

        return null;
    }

    public void SaveLeaderboard()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/leaderboard.dat", FileMode.OpenOrCreate);

        List<Leaderboard> l = new List<Leaderboard>();
        l.Add(new Leaderboard(15));
        l.Add(new Leaderboard(25));
        l.Add(new Leaderboard(31));

        formatter.Serialize(file, l);
        file.Close();
    }
}

[System.Serializable]
public class Leaderboard
{
    public int level;
    public int time;

    public Leaderboard(int time)
    {
        this.time = time;
    }
}