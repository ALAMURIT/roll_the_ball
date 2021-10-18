using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    public Maze_Tilt m;
    public GameObject ove;
    void Start()
    {
        ove.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            m.enabled = false;
            ove.SetActive(true);
            //GameManager.life = 0;
        }
    }
}
