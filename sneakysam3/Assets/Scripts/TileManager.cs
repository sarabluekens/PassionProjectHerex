using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    public float zSpawn = 0; // z variabele waar de tiles moeten spawnen (x en y veranderen niet)

    public float tileLength = 30; // is het wel dertig?
    public int numberOfTiles = 5;

    public Transform playerTransform;


    // Start is called before the first frame update

    void Start()
    {
        //spawnTile(0);
        //spawnTile(1);
        //spawnTile(4);

        for(int i = 0; i < numberOfTiles; i++)
        {
            if (i == 0)
            {
                SpawnTile(0);
            }else
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
        }
        
    }

    public void SpawnTile(int tileIndex)
    {
        Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += tileLength; //zorgen dat ze tegen elkaar spawnen
    }
}
