using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private float rotSpeed = 50;
    public GameObject target;
    public GameObject[] Wheel = new GameObject[1];
    private float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.eulerAngles = new Vector3(0.0f, 45.0f, 0.0f);
        //Quaternion target = Quaternion.Euler(0.0f, 45.0f, 0.0f);
        //transform.rotation = target;
        //Look_At2();
    }
    private void Rotating()
    {
       
       transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
       
    }
    private void Rotating2()
    {

        this.transform.rotation *= Quaternion.AngleAxis(10.0f, Vector3.forward * Time.deltaTime); //보는 방향을 기준
    }
    private void Rotating3()
    {

        float rot = rotSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(rot, Vector3.up);
    }
    private void Rotating4()
    {
        this.transform.RotateAround(new Vector3(0, 0, 0), Vector3.up, rotSpeed * Time.deltaTime); // 벡터를 기준으로 돈다. 축
    }
    private void Rotating5()
    {
       

        float y = Input.GetAxis("Horizontal");//a,d 좌우 키 해당하는값 
        y = y * rotSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, y, 0));
    }
    void Look_At() //바라봄
    {
        Vector3 dirToTarger = target.transform.position - this.transform.position;
     
        if (dirToTarger != null)
        {
            Vector3 dirToTarget = target.transform.position - this.transform.position;
            this.transform.forward = dirToTarget.normalized;
        }

    }

    void Look_At2() //바라봄
    {
        Vector3 dirToTarger = target.transform.position - this.transform.position;

        if (dirToTarger != null)
        {
            Vector3 dirToTarget = target.transform.position - this.transform.position;
            this.transform.rotation = Quaternion.LookRotation(dirToTarget, Vector3.up);
        }

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(KeyCode.A))
        //{
        //    float rot = rotSpeed * Time.deltaTime;
        //    transform.rotation *= Quaternion.AngleAxis(-rot, Vector3.up);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    float rot = rotSpeed * Time.deltaTime;
        //    transform.rotation *= Quaternion.AngleAxis(rot, Vector3.up);
        //}

        
        if (Input.GetKey(KeyCode.A))
        {
            for (int i = 0; i < 2; ++i)
                Wheel[i].transform.Rotate(Vector3.up, -0.5f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            for (int i = 0; i < 2; ++i)
                Wheel[i].transform.Rotate(Vector3.up , 0.5f, Space.World);
        }
        
        

      
    }
}
