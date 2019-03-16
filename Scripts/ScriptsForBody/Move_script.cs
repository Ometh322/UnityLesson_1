using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_script : MonoBehaviour
{
    public GameObject player;
    public float speed = 6.0f;
    public int jumpSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        player = (GameObject)this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float move;
        move = Input.GetAxis("Vertical");
        if (move > 0)
        {
            if (Input.GetKeyUp(KeyCode.LeftShift))
                speed = 12;
            if (Input.GetKeyDown(KeyCode.LeftShift))
                speed = 6;
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
        if (move < 0)
            transform.Translate(transform.forward * -speed * Time.deltaTime);
        move = Input.GetAxis("Horizontal");
        if (move > 0)
            transform.Translate(transform.right * speed * Time.deltaTime);
        if (move < 0)
            transform.Translate(transform.right * -speed * Time.deltaTime);
        move = Input.GetAxis("Jump");
        if (move > 0)
            transform.Translate(transform.up * jumpSpeed * Time.deltaTime);
        
    }
}
