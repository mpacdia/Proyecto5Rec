using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.VisualScripting;

public class enemyBicho1 : MonoBehaviour
{
    NavMeshAgent agentBicho1;
    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
        agentBicho1 = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void chasePlayer()
    {
        agentBicho1.destination = player.transform.position;
    }
}
