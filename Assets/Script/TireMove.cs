using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireMove : MonoBehaviour
{
    private float rotSpeed = 50;
    public GameObject[] tire=  new GameObject[1];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float x = 200 * Time.deltaTime;
            this.transform.Rotate(new Vector3(x, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            float x = 200 * Time.deltaTime;
            this.transform.Rotate(new Vector3(-x, 0, 0));
             
        }
       
    }
}
