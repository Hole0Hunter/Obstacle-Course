using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int numOfBumps = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Hit" || collision.gameObject.tag == "Plane")
        {
            numOfBumps++;
            Debug.Log("You've bumped into a thing this many times: " + numOfBumps);
        }
    }
}
