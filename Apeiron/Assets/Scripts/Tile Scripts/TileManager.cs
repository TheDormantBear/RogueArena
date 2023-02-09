using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileManager : MonoBehaviour
{
	//list of map coordinates
	public List<Vector2> tilePositions = new List<Vector2>();

	//tile prefabs
    [SerializeField] private GameObject spawnTile;
    [SerializeField] private GameObject bossTile;
    [SerializeField] private GameObject gameTile;
	//tiles
	public GameObject originPoint;
	

    // Start is called before the first frame update
    void Start()
    {
    	spawnOrigin();		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//create spawn point
	void spawnOrigin()
	{
		var origin = Instantiate(spawnTile, new Vector2(0, 0), Quaternion.identity); 
		
		origin.transform.parent = this.transform;
		
		originPoint = origin;

		//tilePositions[0] = originPoint.GetComponent<TileDetails>().location;//set up location in details

		createTiles(originPoint.tag);
	}
	
	//create tiles surrounding an orgin (call repeatidly for map fill)
	void createTiles(String tag)
	{
		Debug.Log(tag);
		
		if(tag == "SpawnTile") 
		{
			bool up = originPoint.GetComponent<TileDetails>().upRoom;
			if(up) 
			{			
				Instantiate(gameTile, new Vector2(0, 2), Quaternion.identity);	
			}
			
			
			bool right = originPoint.GetComponent<TileDetails>().rightRoom;
			if(right)
			{			
				Instantiate(gameTile, new Vector2(2, 0), Quaternion.identity);	
			}
			
			bool down = originPoint.GetComponent<TileDetails>().downRoom;
			if(down)
			{			
				Instantiate(gameTile, new Vector2(0, -2), Quaternion.identity);	
			}
			
			bool left = originPoint.GetComponent<TileDetails>().leftRoom;
			if(down)
			{			
				Instantiate(gameTile, new Vector2(-2, 0), Quaternion.identity);	
			}
		}

		if (tag == "GameTile")
        {


        }
	}
}
