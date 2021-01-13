using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    [Range(0,9)]
    
    private float moveSpeed = 0.2f;
   
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.Translate(new Vector3(0.0f, 5.0f, 0));  //현재위치. 로컬 자기자신
        //this.transform.position = new Vector3(0.0f, 5.0f, 0); //월드 

    }

    private void Moving()
    {
        float moveDelta = this.moveSpeed * Time.deltaTime;
        //Vector3 pos = this.transform.position;
        //pos.z += moveDelta;
        //this.transform.position = pos;
        this.transform.Translate(Vector3.forward*moveDelta);

    }
 
    // Update is called once per frame
    void Update()
    {
        //Moving();
       
        if(Input.GetKey(KeyCode.W))
        {
            float moveDelta = this.moveSpeed * Time.deltaTime;
            this.transform.Translate(Vector3.forward * moveDelta);
        }
        if (Input.GetKey(KeyCode.S))
        {
            float moveDelta = this.moveSpeed * Time.deltaTime;
            this.transform.Translate(-Vector3.forward * moveDelta);
        }
        if (Input.GetKey(KeyCode.A))
        {
           this.transform.Rotate(Vector3.up, -0.5f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, 0.5f);
        }

    }
}
