using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public GameObject bichoSeta;
    public GameObject bichoCactus;

    public List<GameObject> listSpawnZones;
    GameObject chosenSpawnZoneSeta;
    GameObject chosenSpawnZoneCactus;
    

    public float waitTimeCactus = 7.0f;
    public float waitTimeSeta = 5.0f;
    private int indexCactus;
    private int indexSeta;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCactusAtInrtervals());
        StartCoroutine(spawnSetaAtInrtervals());
    }

    IEnumerator spawnCactusAtInrtervals()
    {
        while (true)
        {
            spawnCactus();
            yield return new WaitForSeconds(waitTimeCactus);
        }
    }
    
    IEnumerator spawnSetaAtInrtervals()
    {
        while (true)
        {
            spawnSeta();
            yield return new WaitForSeconds(waitTimeSeta);
        }
    }

    void spawnSeta()
    {
        indexSeta = Random.Range(0, 3);
        chosenSpawnZoneSeta = listSpawnZones[indexSeta];
        Instantiate(bichoSeta, chosenSpawnZoneSeta.transform.position, Quaternion.identity);
    } 
    
    void spawnCactus()
    {
        indexCactus = Random.Range(0, 1);
        chosenSpawnZoneCactus = listSpawnZones[indexCactus];
        Instantiate(bichoCactus, chosenSpawnZoneCactus.transform.position, Quaternion.identity);
    }
}
