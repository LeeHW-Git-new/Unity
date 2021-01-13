using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager sInstance;
    public int Score = 0;
    public int nSceneID = -1;
    public RayCastEx[] Ray;

    public static GameManager Instance
    {
        get
        {
            if (sInstance == null)
            {
                GameObject newGameObject = new GameObject("_GameManager");
                sInstance = newGameObject.AddComponent<GameManager>();
            }
            return sInstance;
        }
    }

    private void Awake()
    {
        
        DontDestroyOnLoad(this.gameObject);
      

    }
    //===========



    private void OnGUI()
    {
        if (nSceneID == -1)
        {
            if (GUI.Button(new Rect(400, 240, 150, 30), "자동차 게임 시작"))
            {

                Time.timeScale = 1;
                GameStart();
                nSceneID = 0;
            }
        }

        if (nSceneID == -1)
        {
            if (GUI.Button(new Rect(400, 280, 150, 30), "버드 게임 시작"))
            {
                Score = 0;
                Time.timeScale = 1;
                GameStart2();
                nSceneID = 2;
            }
        }

        if (nSceneID == 1)
        {
            GameEnd();

            if (GameManager.Instance.nSceneID == 1)
            {
                int i, n = 3, j;
                RayCastEx Raytemp;
                for (i = n - 1; i > 0; i--)
                {
                    for (j = 0; j < i; j++)
                    {

                        if (Ray[j].Rank < Ray[j + 1].Rank)
                        {
                            Raytemp = Ray[j];
                            Ray[j] = Ray[j + 1];
                            Ray[j + 1] = Raytemp;
                        }
                    }
                }
                for (i = 0; i < n; i++)
                {
                    print(i + 1 + "등 차는 " + Ray[i].name);
                    
                }

            }
        }

        
    }

    private void GameStart()//자동차
    {
        
        SceneManager.LoadScene("01Basic");
      
    }
    private void GameStart2() //버드
    {

        SceneManager.LoadScene("02Basic");

    }
    private void GameMenu()
    {
        SceneManager.LoadScene("Start");
    }
    private void GameEnd()
    {

        SceneManager.LoadScene("End");

    }

}
