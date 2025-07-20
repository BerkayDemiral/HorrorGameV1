using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LookAtObjects : MonoBehaviour
{
    public TextMeshProUGUI textOB;
    public string description = "Description";

    public bool inReach;

    void Start()
    {
        textOB.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            textOB.enabled = true;
            textOB.text = description;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            textOB.enabled = false;
            textOB.text = "";
        }
    }

    /*void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            textOB.text = description;
        }
    }*/
}