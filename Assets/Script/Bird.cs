using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpPower = 5.0f;
    public int Score = 0;
    Rigidbody vel;
    // Start is called before the first frame update
    void Start()
    {
        vel = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vel.velocity = GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            this.transform.rotation = Quaternion.Euler(0, 0, 10);

        }
       
        if(vel.velocity.y < 3)
            this.transform.rotation = Quaternion.Euler(0, 0, -10);
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall")
        {
            
           GameManager.Instance.Score += 1;
        }
        if (other.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;

            GameManager.Instance.nSceneID = 1;
        }
        if (other.gameObject.tag == "Line")
        {
            Time.timeScale = 0;

            GameManager.Instance.nSceneID = 1;
        }

    }
    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 150, 30), "Score : " + GameManager.Instance.Score);
    }
}
