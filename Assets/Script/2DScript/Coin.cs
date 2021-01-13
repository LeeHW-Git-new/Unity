using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle = null;
    public float range = 200f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            GameObject obj = null;
            if (obstacle != null)
            {
                transform.position = new Vector2(Random.Range(-range, range),
                        Random.Range(-range, range));

                obj = Instantiate(obstacle, transform.position, transform.rotation);
            }
            yield return new WaitForSeconds(8.0f);
        }
    }
}
