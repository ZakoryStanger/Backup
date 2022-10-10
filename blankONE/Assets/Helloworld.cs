using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        string name = "Mr s";
        int health = 20;
        float critchance = 0.2f;
        bool alive = true;
        Vector2 moveder = new Vector2(1, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
