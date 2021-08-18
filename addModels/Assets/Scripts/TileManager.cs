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
    private List<GameObject> activeTiles = new List<GameObject>();

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
        if(playerTransform.position.z - 35 > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            Delete();
        }
        
    }

    public void SpawnTile(int tileIndex)
    {
        GameObject tile = Instantiate(tilePrefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(tile);
        zSpawn += tileLength; //zorgen dat ze tegen elkaar spawnen
    }

    private void Delete()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
