using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_Tilt : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform maze;
    public float multiplier = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 dir = Vector3.zero;
        //dir.x = Input.acceleration.y;
        //dir.z = Input.acceleration.x;
        //transform.rotation();
       // maze.transform.Rotate(dir * multiplier);
        if (Input.GetKey("w"))
        {
            maze.transform.Rotate(1, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            maze.transform.Rotate(-1, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            maze.transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey("a"))
        {
            maze.transform.Rotate(0, 0, -1);
        }
    }
}
