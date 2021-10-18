using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePill : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager man;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            man.isPill = true;
            Destroy(gameObject);
        }
    }
}
