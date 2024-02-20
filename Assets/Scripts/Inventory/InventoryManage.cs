using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private GameObject inventory;
    private GameObject listImventory1, listImventory2, listImventory3;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory");

        listImventory1 = GameObject.Find("List-1");
        listImventory2 = GameObject.Find("List-2");
        listImventory3 = GameObject.Find("List-3");

        ExitInventory();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventory.active)
            {
                ExitInventory();
            }
            else
            {
                inventory.SetActive(true);
                listImventory1.SetActive(false);
                listImventory2.SetActive(true);
                listImventory3.SetActive(false);
            }

        }
    }
    public void ExitInventory()
    {
        inventory.SetActive(false);
    }
}
