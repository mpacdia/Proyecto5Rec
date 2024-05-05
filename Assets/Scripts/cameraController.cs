using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class cameraController : MonoBehaviour
{
    

    public CinemachineVirtualCamera cameraInitial;
    public CinemachineVirtualCamera cameraZone1;
    public CinemachineVirtualCamera cameraZone2;
    public CinemachineVirtualCamera cameraZone3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "initialZone")
        {
            cameraInitial.Priority = 1;
            cameraZone1.Priority = 0;
            cameraZone2.Priority = 0;
            cameraZone3.Priority = 0;
        }

        if (other.gameObject.tag == "zone1")
        {
            cameraInitial.Priority = 0;
            cameraZone1.Priority = 1;
            cameraZone2.Priority = 0;
            cameraZone3.Priority = 0;
        }
        
        if (other.gameObject.tag == "zone2")
        {
            cameraInitial.Priority = 0;
            cameraZone1.Priority = 0;
            cameraZone2.Priority = 1;
            cameraZone3.Priority = 0;
        }

        if (other.gameObject.tag == "zone3")
        {
            cameraInitial.Priority = 0;
            cameraZone1.Priority = 0;
            cameraZone2.Priority = 0;
            cameraZone3.Priority = 1;
        }
    }
}
