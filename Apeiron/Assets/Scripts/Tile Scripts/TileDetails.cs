using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDetails : MonoBehaviour
{
    private bool upRoom = false;
    private bool rightRoom = false;
    private bool downRoom = false;
    private bool leftRoom = false;
    // Start is called before the first frame update
    void Start()
    {
        sisterRoomDirections();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sisterRoomDirections()
    {
        //get probability of sister rooms
        int upProb = Random.Range(0, 2);
        int rightProb = Random.Range(0, 2);
        int downProb = Random.Range(0, 2);
        int leftProb = Random.Range(0, 2);

        //debug (display sister room probabilities)
        Debug.Log(upProb);
        Debug.Log(rightProb);
        Debug.Log(downProb);
        Debug.Log(leftProb);
    }
}
