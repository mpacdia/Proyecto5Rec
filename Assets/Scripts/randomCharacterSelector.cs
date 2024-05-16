using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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

    private GameObject player;
    public GameObject Player
    {
        get { return player; }
        set { player = value; }
    }


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
        index = Random.Range(0, randomCharacter.Count);
        player = Instantiate(randomCharacter[index], new Vector3(50, 5, -50), Quaternion.identity);
        player.GetComponent<damageContorller>().HitsLeft = 3;
        //
    }


    // Update is called once per frame
    void Update()
    {       
        spawnCharacter();        
    }

    

    void spawnCharacter()
    {
        if (player != null && player.GetComponent<damageContorller>().HitsLeft == 0)
        {
            index = Random.Range(0, randomCharacter.Count);
            player = Instantiate(randomCharacter[index], new Vector3(50, 5, -50),Quaternion.identity);
            player.GetComponent<damageContorller>().HitsLeft = 3;
        }
    }
}
