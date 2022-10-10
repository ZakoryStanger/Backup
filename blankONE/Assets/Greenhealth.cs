using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Greenhealth : MonoBehaviour
{
    public int health = 15;
    public TextMeshProUGUI HealthText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HealthText.text = "GREEN=" + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherName = collision.gameObject.name;
        if (otherName == "Spike")
        {
            health--;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        string otherName = collision.gameObject.name;
        if (otherName == "Spike")
        {
            health--;
            if (health <= 0)
            {
                health = 0;
            }
        }
    }
}
