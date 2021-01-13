using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.right * 300 * Time.deltaTime);
        if(this.transform.position.x  > 500)
        {
            Destroy(this.gameObject);
        }
    }
}
