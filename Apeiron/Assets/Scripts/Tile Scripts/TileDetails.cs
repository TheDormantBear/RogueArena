using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDetails : MonoBehaviour
{
	//direction bools
    public bool upRoom = false;
    public bool rightRoom = false;
    public bool downRoom = false;
    public bool leftRoom = false;
	//variables
	public bool dirFound = false;
    // Start is called before the first frame update
    void Awake()
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
		
		if(this.tag == "SpawnTile") 
		{
			//up
			if(upProb == 1) 
			{
				upRoom = true;
			}
			if(upProb == 0) 
			{
				upRoom = false;
			}
			//right
			if(rightProb == 1) 
			{
				rightRoom = true;
			}
			if(rightProb == 0) 
			{
				rightRoom = false;
			}
			//down
				if(downProb == 1) 
			{
				downRoom = true;
			}	
				if(downProb == 0) 
			{
				downRoom = false;
			}
			//left
			if(leftProb == 1) 
			{	
				leftRoom = true;
			}
			if(leftProb == 0) 
			{
				leftRoom = false;
			}	
			dirFound = true;
		}
		
    }
}
