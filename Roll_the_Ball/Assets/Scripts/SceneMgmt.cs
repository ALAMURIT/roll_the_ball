using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgmt : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ob;
    private void Start()
    {
        ob.SetActive(false);
    }
    public void starte()
    {
        SceneManager.LoadScene("Level_One");
    }
    //public void restarte()
    //{
    //    SceneManager.LoadScene("LevelOne");
    //}
    public void menu()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void abt()
    {
        ob.SetActive(true);
        //SceneManager.LoadScene("About");
    }
    public void ext()
    {
        ob.SetActive(false);
    }
    
}
