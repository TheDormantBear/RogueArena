using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TileManager : MonoBehaviour
{
    [SerializeField] private GameObject spawnTile;
    [SerializeField] private GameObject bossTile;
    [SerializeField] private GameObject gameTile;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(spawnTile, new Vector2(0, 0), Quaternion.identity);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
