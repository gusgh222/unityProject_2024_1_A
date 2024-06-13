using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievemetManager : MonoBehaviour
{
    public static AchievemetManager instance;
    public List<Achievemet> achievemets;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void AddProgress(string achievementName, int amount)
    {
        Achievemet achievemet = achievemets.Find(a => a.name == achievementName);
        if(achievemet != null)
        {
            achievemet.AddProgress(amount);
        }
    }
}
