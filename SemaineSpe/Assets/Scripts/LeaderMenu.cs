﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;

public class LeaderMenu : MonoBehaviour
{
    public List<TextMeshProUGUI> level1GUI;
    public List<TextMeshProUGUI> level2GUI;

    private List<Leaderboard> firstLevel = new List<Leaderboard>();
    private List<Leaderboard> secondLevel = new List<Leaderboard>();
    void Start()
    {
        //SaveLeaderboard();

        firstLevel = Leaderboard.FirstLevel();
        secondLevel = Leaderboard.SecondLevel();

        if (firstLevel != null)
        {
            level1GUI[0].GetComponent<TextMeshProUGUI>().text = firstLevel[0].time.ToString();
            level1GUI[1].GetComponent<TextMeshProUGUI>().text = firstLevel[1].time.ToString();
            level1GUI[2].GetComponent<TextMeshProUGUI>().text = firstLevel[2].time.ToString();
        }

        if (secondLevel != null)
        {
            level2GUI[0].GetComponent<TextMeshProUGUI>().text = secondLevel[0].time.ToString();
            level2GUI[1].GetComponent<TextMeshProUGUI>().text = secondLevel[1].time.ToString();
            level2GUI[2].GetComponent<TextMeshProUGUI>().text = secondLevel[2].time.ToString();
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