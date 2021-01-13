using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject GM;
    Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        MainCamera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
        MoveCamera();
        ZoomCamera();
    }

    private void OnPreCull()
    {
        
    }

    private void OnPreRender()
    {
        
    }
    void ZoomCamera()
    {
    
        MainCamera.fieldOfView += (20.0f * Input.GetAxis("Mouse ScrollWheel"));
        if (MainCamera.fieldOfView < 10)
            MainCamera.fieldOfView = 10;
    }
    void MoveCamera()
    {
        if(Input.GetMouseButton(0))
        {
            this.transform.Translate(Input.GetAxisRaw("Mouse X") / 5, Input.GetAxisRaw("Mouse Y") / 5,
               0);

        }
    }
    void RotateCamera()
    {
        if(Input.GetMouseButton(1))
        {
            
            this.transform.RotateAround(GM.transform.position, Vector3.down,  20 * Time.deltaTime);
        }
    }
}
