using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyBicho1 : MonoBehaviour
{
    NavMeshAgent agentBicho1;
    
    private float waitTime = 2.5f;

    randomCharacterSelector rcs;

    // Start is called before the first frame update
    void Start()
    {
        agentBicho1 = GetComponent<NavMeshAgent>();
        rcs = GameObject.Find("characterInitialPos").GetComponent<randomCharacterSelector>();
        StartCoroutine(chasePlayerAtIntervals());
    }

    IEnumerator chasePlayerAtIntervals()
    {
        while(true)
        {
            chasePlayer();
            yield return new WaitForSeconds(waitTime);
        }
    }


    void chasePlayer()
    {
        Debug.Log(rcs.Player);
        agentBicho1.destination = rcs.Player.transform.position;
    }
}
