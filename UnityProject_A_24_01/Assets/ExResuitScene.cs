using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExResuitScene : MonoBehaviour
{
    public Text TextUI;
    
    // Start is called before the first frame update
    public void Start()
    {
        TextUI.text = PlayerPrefs.Getlnt ("Point").ToString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("MainScene");
    }
}
