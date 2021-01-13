using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager2D : MonoBehaviour
{
    private static SoundManager2D sInstance = null;

    public AudioClip[] audioClips = null;
    private AudioSource audioSource = null;

    public static SoundManager2D Instance
    {
        get
        {
            if (sInstance == null)
            {

                GameObject newGameObject = new GameObject("SoundManager2D");
                sInstance = newGameObject.AddComponent<SoundManager2D>();
            }
            return sInstance;
        }
    }
    // Start is called before the first frame update
   void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }
   

    // Update is called once per frame
    void Update()
    {
        //SoundTest_1();
    }

    void SoundTest_1()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
            StopAndPlay(0);

        if (Input.GetKeyDown(KeyCode.Keypad2))
            StopAndPlay(1);

        if (Input.GetKeyDown(KeyCode.Keypad3))
            StopAndPlay(2);
    }

    public void StopAndPlay(int clipIndex)
    {
        audioSource.Stop();
        audioSource.loop = false;
        if(clipIndex == 0)
        {
            audioSource.clip = Resources.Load("2D_Resources/Sound/get")
                as AudioClip;
        }
        if(clipIndex == 1 )
        {
            audioSource.clip = Resources.Load("2D_Resources/Sound/damaged")
     as AudioClip;
        }
        audioSource.Play();
    }
}
