using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_script : MonoBehaviour
{
    public float rot_speed = 10f;
    void Start()
    {
        Vector3 rotationVector = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);

    }

    void Update()
    {
        float y = 0;
        y += Input.GetAxis("Vertical");
        transform.rotation = Quaternion.Euler(0, y * Mathf.Sin(Time.time * 8) * rot_speed, 0);
    }
}
