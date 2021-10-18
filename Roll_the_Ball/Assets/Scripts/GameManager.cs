using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame 
    public static int life;
    public static int scor;
    public bool isPill;
    public GameObject ov;
    //public static float rcou;
    public Maze_Tilt mov;
    public TextMeshProUGUI l;
    public TextMeshProUGUI s;
    public TextMeshProUGUI Hs;
    public TextMeshProUGUI re;
    public TextMeshProUGUI rwc;
    //public static string rew;
    //public static TextMeshProUGUI re;
    void Start()
    {
        isPill = false;
        life = 3;
        scor = 0;
        ov.SetActive(false);
        //rcou = 3f;
        //rew = " ";
        //Hs.text = PlayerPrefs.GetFloat("HighScore", 0f).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0f)
        {

            ov.SetActive(true);
            mov.enabled = false;
            //SceneManager.LoadScene("GameOvr");
        }
        //if (life > 0f)
        //{
            //mov.enabled = true;
        //}
        //if (rcou <= 0)
        //{
          //  mov.enabled = false;
            //SceneManager.LoadScene("GameOver");
        //}
        l.text = ("LIFE " + life.ToString());
        s.text = ("Score " + scor.ToString());
        //rwc.text = ("Rewinds " + rcou.ToString());
        //re.text = (rew);
        //if(scor>PlayerPrefs.GetFloat("HighScore", 0f))
        //{
        //    PlayerPrefs.SetFloat("HighScore", scor);
            //Hs.text = scor.ToString();
        //}
    }
}
