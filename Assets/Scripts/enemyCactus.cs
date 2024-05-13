using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyCactus : MonoBehaviour
{
    NavMeshAgent agentCactus;
   
    private float waitTime = 2.5f;

    public randomCharacterSelector rcs;

    // Start is called before the first frame update
    void Start()
    {
        agentCactus = GetComponent<NavMeshAgent>();
        rcs = GameObject.Find("characterInitialPos").GetComponent<randomCharacterSelector>();
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
        agentCactus.destination = rcs.Player.transform.position;
    }
}
