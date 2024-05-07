using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class damageContorller : MonoBehaviour
{
    private int hitsLeft = 0;

    public int HitsLeft   // property
    {
        get { return hitsLeft; }
        set {
            if (value < 0)
            {
                value = 0;
            }
            hitsLeft = value; }
    }

    // public int var;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            hitsLeft -= 1;
        }
    }
}
