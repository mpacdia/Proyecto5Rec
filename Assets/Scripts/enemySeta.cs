using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemySeta : MonoBehaviour
{
    NavMeshAgent agentSeta;

    private float waitTime = 2.5f;

    randomCharacterSelector rcs;

    // Start is called before the first frame update
    void Start()
    {
        agentSeta = GetComponent<NavMeshAgent>();
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
        agentSeta.destination = rcs.Player.transform.position;
    }
}
