using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class damageContorller : MonoBehaviour
{
    private int hitsLeft = 0;

    public TMP_Text hitsLeftText;

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
    private void Start()
    {
        hitsLeftText = GameObject.Find("hitsLeftText").GetComponent<TMP_Text>();
    }

    private void FixedUpdate()
    {
        hitsLeftText.text = "HitsLeft:" + HitsLeft.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            hitsLeft -= 1;
        }
    }
}
