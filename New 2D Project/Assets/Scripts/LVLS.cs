using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Level1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL1");
    }
    public void Level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Level3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("LVL3");
    }
}
