using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawnEnemies : MonoBehaviour
{
    public GameObject bichoSeta;
    public GameObject bichoCactus;
    public NavMeshAgent agentSeta;
    public NavMeshAgent agentCactus;

    public List<GameObject> listSpawnZones;
    GameObject chosenSpawnZoneSeta;
    GameObject chosenSpawnZoneCactus;
    

    public float waitTimeCactus = 7.0f;
    public float waitTimeSeta = 5.0f;
    private int indexCactus;
    private int indexSeta;

    public randomCharacterSelector rcs;

    // Start is called before the first frame update
    void Start()
    {
        agentSeta = bichoSeta.GetComponent<NavMeshAgent>();
        agentCactus = bichoCactus.GetComponent<NavMeshAgent>();
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
        GameObject bichoSetaNuevo =  Instantiate(bichoSeta, chosenSpawnZoneSeta.transform.position, Quaternion.identity);
        if(rcs.Player != null) 
          bichoSetaNuevo.GetComponent<NavMeshAgent>().destination = rcs.Player.transform.position;
    } 
    
    void spawnCactus()
    {
        indexCactus = Random.Range(0, 1);
        chosenSpawnZoneCactus = listSpawnZones[indexCactus];
        GameObject bichoCactusNuevo  =  Instantiate(bichoCactus, chosenSpawnZoneCactus.transform.position, Quaternion.identity);
        if (rcs.Player != null)  bichoCactusNuevo.GetComponent<NavMeshAgent>().destination = rcs.Player.transform.position;
    }
}
