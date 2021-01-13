using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEffect : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine("ShotEffect_Coroutine");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ShotEffect_Coroutine()
    {

        while(animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            yield return null;

        Destroy(gameObject);


    }
}
