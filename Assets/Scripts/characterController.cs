using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class characterController : MonoBehaviour
{
    public NavMeshAgent playerAgent;

    List<GameObject> randomCharacter = new List<GameObject>();
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;
    public GameObject character5;
    public GameObject character6;
    public GameObject character7;
    int index;

    public GameObject player;

    public CinemachineVirtualCamera cameraInitial;
    public CinemachineVirtualCamera camera1;
    public CinemachineVirtualCamera camera2;
    public CinemachineVirtualCamera camera3;

    public int hitsLeft = 0;

    float mvmntSpeed = 5;

    Rigidbody rb;

    private float movX;
    private float movY;

    // Start is called before the first frame update
    void Start()
    {
        randomCharacter.Add(character1);
        randomCharacter.Add(character2);
        randomCharacter.Add(character3);
        randomCharacter.Add(character4);
        randomCharacter.Add(character5);
        randomCharacter.Add(character6);
        randomCharacter.Add(character7);

        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        spawnCharacter();

        
    }

    private void FixedUpdate()
    {
        Vector3 speed = new Vector3(movX * mvmntSpeed, rb.velocity.y, movY * mvmntSpeed);
        rb.velocity = speed;
    }

    void spawnCharacter()
    {
        if (hitsLeft == 0)
        {
            index = Random.Range(0, randomCharacter.Count);
            player = randomCharacter[index];
            Instantiate(player,new Vector3(50, 5, -50),Quaternion.identity);
            hitsLeft = 3;
        }
    }
}
