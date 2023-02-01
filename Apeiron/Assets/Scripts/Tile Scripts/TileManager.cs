using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileManager : MonoBehaviour
{
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
	
	void spawnOrigin()
	{
		var origin = Instantiate(spawnTile, new Vector2(0, 0), Quaternion.identity); 
		
		origin.transform.parent = this.transform;
		
		originPoint = origin;
		
		createTiles(originPoint.tag);
	}
	
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
	}
}
