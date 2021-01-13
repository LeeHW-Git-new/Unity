using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2D : MonoBehaviour
{
    private static GameManager2D sInstance;
    public int Score = 0;

    // Start is called before the first frame update
    public static GameManager2D Instance
    {
        get
        {
            if (sInstance == null)
            {
                GameObject newGameObject = new GameObject("GameManager2D");
                sInstance = newGameObject.AddComponent<GameManager2D>();
            }
            return sInstance;
        }
    }
    // Update is called once per frame

    public void AddScore()
    {
        Score += 10;
    }
}
