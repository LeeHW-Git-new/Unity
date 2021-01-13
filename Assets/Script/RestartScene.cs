using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        GameManager.Instance.nSceneID = 2;
    }
    private void OnGUI()
    {

        if (GameManager.Instance.nSceneID == 2)
        {
            GUI.Label(new Rect(0, 0, 150, 30), "최종 Score : " +
                GameManager.Instance.Score);

            if (GUI.Button(new Rect(400, 240, 100, 30), "게임 다시 시작"))
            {
                SceneManager.LoadScene("Start");
                GameManager.Instance.nSceneID = -1;

            }
        }

        /*
        int i , n = 3, j;
        RayCastEx Raytemp;
        for (i = n - 1; i > 0; i--)
        {
            for (j = 0; j < i; j++)
            {

                if (GameManager.Instance.Ray[j].Rank < GameManager.Instance.Ray[j + 1].Rank)
                {
                    Raytemp = GameManager.Instance.Ray[j];
                    GameManager.Instance.Ray[j] = GameManager.Instance.Ray[j + 1];
                    GameManager.Instance.Ray[j + 1] = Raytemp;
                }
            }
        }
        for (i = 0; i < n; i++)
        {
            print(i + 1 + "등 차는 " + GameManager.Instance.Ray[i].name + " " 
                + GameManager.Instance.Ray[i].Rank);
        }
        */


    }
    // Update is called once per frame

}