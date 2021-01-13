using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.nSceneID = 2;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(-Vector3.right* 7 * Time.deltaTime);

        
    }

  
}
