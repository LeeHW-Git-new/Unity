using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    float rotSpeed = 50.0f;
    private void Rotating5()
    {
        float y = Input.GetAxis("Horizontal");//a,d 좌우 키 해당하는값 
        y = y * rotSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, y, 0));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            float x = 200 * Time.deltaTime;
            this.transform.Rotate(new Vector3(0, x, 0));
        }
        if (Input.GetKey(KeyCode.E))
        {
            float x = 200 * Time.deltaTime;
            this.transform.Rotate(new Vector3(0, -x, 0));

          
        }
    }
}
