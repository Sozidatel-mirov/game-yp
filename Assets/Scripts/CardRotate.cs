using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRotate : MonoBehaviour
{
    GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        card = GameObject.FindGameObjectWithTag("Card");
    }

    // Update is called once per frame
    void Update()
    {
        card.transform.Rotate(0, 0.2f, 0);
    }
}
