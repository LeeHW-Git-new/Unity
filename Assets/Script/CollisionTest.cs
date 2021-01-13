using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    public float speedMove = 0.4f;
    public float speedRot = 5.0f;
    // Start is called before the first frame update

    Rigidbody rigidbody = null;



    void Start()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move_Rotate();
    }

    private void Move_Rotate()
    {
        float rot = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");
        
        rot = rot * speedRot;
        move = move * speedMove;

        this.gameObject.transform.Rotate(Vector3.up * rot);
        this.gameObject.transform.Translate(Vector3.forward * move);


    
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject hitObject = collision.gameObject;
        print("충돌 시작" + hitObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        GameObject hitObject = collision.gameObject;
        print("충돌 중" + hitObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        GameObject hitObject = collision.gameObject;
        print("충돌 끝" + hitObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hitObject = other.gameObject;
        print("트리거 충돌 시작" + hitObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
        GameObject hitObject = other.gameObject;
        print("트리거 충돌 중" + hitObject.name);
    }
    private void OnTriggerExit(Collider other)
    {
        GameObject hitObject = other.gameObject;
        print("트리거 충돌 끝" + hitObject.name);
    }
}
