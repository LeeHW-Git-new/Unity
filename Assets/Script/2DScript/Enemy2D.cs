using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2D : MonoBehaviour
{
    public GameObject obstacle = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-Vector2.right * 250 * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || this.transform.position.x < 0)
        {
            GameObject obj = null;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            obj = Instantiate(obstacle, transform.position, transform.rotation);
            GameManager2D.Instance.Score += 10;
            SoundManager2D.Instance.StopAndPlay(1);
        }
    }
}
