using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2D : MonoBehaviour
{

    private Rigidbody2D rig;

    public float maxSpeed = 2000.0f;

    public GameObject Bullet = null;
    public GameObject BulletT;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }
    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 150, 30), "Score : " + GameManager2D.Instance.Score);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Move_2(x, y);
        Click();
    }


    void Move_1(float x , float y)
    {
        rig.AddForce(new Vector2(x * maxSpeed * Time.deltaTime,
            y * maxSpeed * Time.deltaTime));
    }

    void Move_2(float x, float y)
    {
        Vector3 position = rig.transform.position;
        position = new Vector3(position.x + (x * maxSpeed * Time.deltaTime), 
            position.y + (y * maxSpeed * Time.deltaTime),
            position.z);

        rig.MovePosition(position);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject , 0.3f);
            GameManager2D.Instance.Score += 10;
            SoundManager2D.Instance.StopAndPlay(0);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    void Click()
    {
        GameObject obj;
        if (Input.GetMouseButtonDown(0))
        {
            obj = Instantiate(Bullet,new Vector2(this.transform.position.x + 100,
                this.transform.position.y),
                BulletT.transform.rotation);
        }
    }
}
