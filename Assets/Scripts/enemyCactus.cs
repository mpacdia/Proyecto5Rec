using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyCactus : MonoBehaviour
{
    NavMeshAgent agentCactus;
    public GameObject player;
    private float waitTime = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        agentCactus = GetComponent<NavMeshAgent>();
        StartCoroutine(chasePlayerAtIntervals());
    }

    IEnumerator chasePlayerAtIntervals()
    {
        while (true)
        {
            chasePlayer();
            yield return new WaitForSeconds(waitTime);
        }
    }


    void chasePlayer()
    {
        agentCactus.destination = player.transform.position;
    }
}
