using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXAchiebevement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AchievemetManager.instance.AddProgress("점프", 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AchievemetManager.instance.AddProgress("하강", 1);
        }
    }
}
