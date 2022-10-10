using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions: MonoBehaviour
{
    int level = 10;
    public int Xp = 0;
    int Xptolevel = 100;
    int Maxlevel = 12;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (level < Maxlevel)
        {
            if (Xp >= Xptolevel)
            {
                level++;
                Debug.Log("Ding! you reached level " + level);
                Xp = Xp - Xptolevel;
                Xptolevel += 10;
            }
        }
    }
}