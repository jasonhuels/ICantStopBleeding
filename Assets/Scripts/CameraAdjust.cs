using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdjust : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

  float minFov = 15f;
  float maxFov  = 90f;
  float sensitivity = 10f;
 
 void Update()
  {
    float fov = Camera.main.fieldOfView;
    fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
    fov = Mathf.Clamp(fov, minFov, maxFov);
    Camera.main.fieldOfView = fov;
  }
}
