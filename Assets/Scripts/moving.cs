using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics.Internal;
using UnityEngine;
using UnityEngine.AI;

public class moving : MonoBehaviour
{

    NavMeshAgent playerAgent;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        playerAgent = player.GetComponent<NavMeshAgent>();

    }


    // Update is called once per frame
    void Update()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(cameraRay, out hit))
            {
                playerAgent.destination = hit.point;
            }
        }
    }
}
