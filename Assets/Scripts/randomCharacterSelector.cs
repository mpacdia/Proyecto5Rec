using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class randomCharacterSelector : MonoBehaviour
{

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

    public int hitsLeft = 0;

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

    }


    // Update is called once per frame
    void Update()
    {       
        spawnCharacter();        
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
