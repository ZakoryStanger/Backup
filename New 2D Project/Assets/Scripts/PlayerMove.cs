using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        Debug.Log(xinput);
        float yinput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("xImput", xinput);
        GetComponent<Animator>().SetFloat("yImput", yinput);
        Vector2 moveder = new Vector2(xinput, yinput);
        GetComponent<Rigidbody2D>().velocity = moveder * speed;
    }
}
