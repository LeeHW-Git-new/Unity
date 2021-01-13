using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    public GameObject[] Car;
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Ray = new RayCastEx[Car.Length];
        for (int i = 0; i < 3; ++i)
        {
            GameManager.Instance.Ray[i] = Car[i].GetComponent<RayCastEx>();
        }
    }

    private void Update()
    {

        if (GameManager.Instance.Ray[0].round >= 2 && GameManager.Instance.Ray[1].round >= 2 && GameManager.Instance.Ray[2].round >= 2)
        {
            GameManager.Instance.nSceneID = 1;
        }

        for(int i = 0; i < 3; ++i)
        {
            if (GameManager.Instance.Ray[i].round >= 2)
            {
                GameManager.Instance.Ray[i].Rank++;
            }
        }
     
    }
    // Update is called once per frame

    private void OnGUI()
    {
        for (int i = 0; i < 3; ++i)
        {
            if (GameManager.Instance.Ray[i])
            {
                GUI.Label(new Rect(15, 15 * i+ 15, 150, 30), i + 1  + " 번째 차 Round = " + GameManager.Instance.Ray[i].round);
               
            }
        }
    }

}
