using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCastEx : MonoBehaviour
{
    [Range(0, 50)]
    public float distance = 1.0f;

    public int round = 0;
    public int Rank = 0;
    float moveSpeed = 5.0f;

    private RaycastHit rayHit;
    private Ray rightForwardRay;
    private Ray leftForwardRay;
    private Ray forwardRay;
    private Ray leftRay;
    private Ray rightRay;

    // Start is called before the first frame update
    void Start()
    {
        rightForwardRay = new Ray(this.transform.position, Quaternion.Euler(0, 45, 0) * this.transform.forward);
        leftForwardRay = new Ray(this.transform.position, Quaternion.Euler(0, -45, 0) * this.transform.forward);
        forwardRay = new Ray(this.transform.position, this.transform.forward);
        rightRay = new Ray(this.transform.position, this.transform.right);
        leftRay = new Ray(this.transform.position, -this.transform.right);

        
    }

    // Update is called once per frame
    void Update()
    {
        rightForwardRay.origin = transform.position;
        rightForwardRay.direction = Quaternion.Euler(0, 45, 0) * this.transform.forward;

        leftForwardRay.origin = transform.position;
        leftForwardRay.direction = Quaternion.Euler(0, -45, 0) * this.transform.forward;

        forwardRay.origin = transform.position;
        forwardRay.direction = transform.forward;

        rightRay.origin = transform.position;
        rightRay.direction = this.transform.right;

        leftRay.origin = transform.position;
        leftRay.direction = -this.transform.right;

        MoveForward();
        

        if ((Physics.Raycast(leftForwardRay, out rayHit, distance) || Physics.Raycast(leftRay, out rayHit, distance)) && (!Physics.Raycast(rightForwardRay, out rayHit, distance) || !Physics.Raycast(rightRay, out rayHit, distance)))
        {
            RotateRight();
        }

        if ((Physics.Raycast(rightForwardRay, out rayHit, distance) || Physics.Raycast(rightRay, out rayHit, distance)) && (!Physics.Raycast(leftForwardRay, out rayHit, distance) || !Physics.Raycast(leftRay, out rayHit, distance)))
        {
            RotateLeft();
        }

        if(round == 2)
        {
            moveSpeed = 0;
        }

    }
    void MoveForward()
    {
        float moveDelta = this.moveSpeed * Time.deltaTime;
        this.transform.Translate(Vector3.forward * moveDelta);
    }
    void RotateLeft()
    {
        this.transform.Rotate(Vector3.up, -1.0f, Space.World);
    }
    void RotateRight()
    {
        this.transform.Rotate(Vector3.up, 1.0f, Space.World);
    }

    //void Ray_1_1()
    //{
    //    if (Physics.Raycast(ray, out rayHit, distance))
    //    {
    //        Debug.Log(rayHit.collider.gameObject.name);
    //    }
    //}

    //private RaycastHit[] rayHits;
    //void Ray_1_2()
    //{
    //    rayHits = Physics.RaycastAll(ray, distance);

    //    for (int index = 0; index < rayHits.Length; index++)
    //    {
    //        Debug.Log(rayHits[index].collider.gameObject.name + "hit!!");
    //    }
    //}

    //void Ray_1_3()
    //{
    //    rayHits = Physics.RaycastAll(ray, distance);
    //    for(int index = 0; index < rayHits.Length;index++)
    //    {
    //        if(rayHits[index].collider.gameObject.tag == "Enemy")
    //        {
    //            Debug.Log(rayHits[index].collider.gameObject.name + " hit!! - tag");
    //        }
    //        if(rayHits[index].collider.gameObject.layer == LayerMask.NameToLayer("Test3"))
    //        {
    //            Debug.Log(rayHits[index].collider.gameObject.name + " hit!! - layer");
    //        }
    //    }
    //}

    private void OnDrawGizmos()
    {
        Debug.DrawRay(forwardRay.origin, forwardRay.direction * distance, Color.red);
        Debug.DrawRay(leftForwardRay.origin, leftForwardRay.direction * distance, Color.blue);
        Debug.DrawRay(rightForwardRay.origin, rightForwardRay.direction * distance, Color.blue);
        Debug.DrawRay(rightRay.origin, rightRay.direction * distance, Color.green);
        Debug.DrawRay(leftRay.origin, leftRay.direction * distance, Color.green);
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            moveSpeed--;
        }
        if (other.gameObject.tag == "Line")
        {
            round++;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            moveSpeed++;
        }
        if (other.gameObject.tag == "Line")
        {
           
            
        }
    }
   
  



    //Physics.SphereCastAll()
    //Physics.BoxCastAll()

}
