using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2D : MonoBehaviour
{
    public GameObject obstacle = null;
    public float range = 3.0f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            GameObject obj = null;
            if (obstacle != null)
            {
                transform.position = new Vector2(transform.position.x,
                        Random.Range(-range, range));
                
                obj = Instantiate(obstacle, transform.position, transform.rotation);
            }
            Destroy(obj, 8.0f);

            yield return new WaitForSeconds(1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
