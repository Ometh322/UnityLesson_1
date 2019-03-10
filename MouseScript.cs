using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    Renderer red;
    Vector3 pos = new Vector3();
    public MeshFilter sphere;
    public MeshFilter cube;
    public MeshFilter my;
    // Start is called before the first frame update
    void Start()
    {
        red = GetComponent<Renderer>();
        my = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        transform.localScale = new Vector3(10f, 10f, 10f);
        my.sharedMesh = cube.sharedMesh;
    }
    private void OnMouseExit()
    {
        my.sharedMesh = sphere.sharedMesh;
        transform.localScale = new Vector3(2f, 2f, 2f);
        //transform.rotation = Quaternion.Euler(pos);
        //pos = Input.mousePosition;
    }
    private void OnMouseUp()
    {
        my.sharedMesh = sphere.sharedMesh;
    }
    private void OnMouseOver()
    {
        red.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

}
