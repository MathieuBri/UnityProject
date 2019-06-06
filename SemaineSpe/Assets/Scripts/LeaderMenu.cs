using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;

public class LeaderMenu : MonoBehaviour
{
    private List<Leaderboard> firstlevel = new List<Leaderboard>();
    private List<Leaderboard> secondLevel = new List<Leaderboard>();
    void Start()
    {
        //SaveLeaderboard();

        firstlevel = Leaderboard.FirstLevel();
        secondLevel = Leaderboard.SecondLevel();

        if (firstlevel != null)
        {
            GameObject.Find("Level1FirstTime").GetComponent<TextMeshProUGUI>().text = firstlevel[0].time.ToString();
            GameObject.Find("Level1SecondTime").GetComponent<TextMeshProUGUI>().text = firstlevel[1].time.ToString();
            GameObject.Find("Level1ThirdTime").GetComponent<TextMeshProUGUI>().text = firstlevel[2].time.ToString();
        }

        if (secondLevel != null)
        {
            GameObject.Find("Level2FirstTime").GetComponent<TextMeshProUGUI>().text = secondLevel[0].time.ToString();
            GameObject.Find("Level2SecondTime").GetComponent<TextMeshProUGUI>().text = secondLevel[1].time.ToString();
            GameObject.Find("Level2ThirdTime").GetComponent<TextMeshProUGUI>().text = secondLevel[2].time.ToString();
        }
    }

    public void SaveLeaderboard()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/leaderboard.dat", FileMode.OpenOrCreate);

        List<Leaderboard> l = new List<Leaderboard>();
        l.Add(new Leaderboard(1, 15));
        l.Add(new Leaderboard(1, 25));
        l.Add(new Leaderboard(1, 31));

        l.Add(new Leaderboard(2, 14));
        l.Add(new Leaderboard(2, 28));
        l.Add(new Leaderboard(2, 87));

        formatter.Serialize(file, l);
        file.Close();
    }
}

[System.Serializable]
public class Leaderboard
{
    public int level;
    public int time;

    private static List<Leaderboard> content;

    public Leaderboard(int level, int time)
    {
        this.level = level;
        this.time = time;
    }

    private static List<Leaderboard> Load()
    {
        if (File.Exists(Application.persistentDataPath + "/leaderboard.dat"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/leaderboard.dat", FileMode.Open);

            content = formatter.Deserialize(file) as List<Leaderboard>;
            file.Close();

            return content;
        }

        return null;
    }

    public static List<Leaderboard> FirstLevel()
    {
        return Leaderboard.Load().FindAll(el => el.level == 1);
    }

    public static List<Leaderboard> SecondLevel()
    {
        return Leaderboard.Load().FindAll(el => el.level == 2);
    }
}