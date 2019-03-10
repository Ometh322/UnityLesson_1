using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_script : MonoBehaviour
{
    public GameObject player;
    public int speed = 5;
    public int speedRotation = 3;
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
            transform.Translate(transform.forward * 6.0f * Time.deltaTime);
        if (move < 0)
            transform.Translate(transform.forward * -6.0f * Time.deltaTime);
        move = Input.GetAxis("Horizontal");
        if (move > 0)
            transform.Translate(transform.right * 6.0f * Time.deltaTime);
        if (move < 0)
            transform.Translate(transform.right * -6.0f * Time.deltaTime);
        move = Input.GetAxis("Jump");
        if (move > 0)
            transform.Translate(transform.up * 6.0f * Time.deltaTime);
    }
}
