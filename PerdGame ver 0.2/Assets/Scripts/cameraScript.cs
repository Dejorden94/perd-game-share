using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Bron: https://www.youtube.com/watch?v=sNmeK3qK7oA
//Kanaal:Sebastian Lague
public class cameraScript : MonoBehaviour
{
    public float mouseSensitivity = 10;

    public Transform target;
    public float dstFromTarget = 2;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationSmoothTime = 0.12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float yaw;
    float pitch;
    

    void FixedUpdate() 
    {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }
    // Late update omdat target position dan al juist gezet is.
    void LateUpdate()
    {
        yaw += Input.GetAxis ("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);

        transform.eulerAngles = currentRotation;

        transform.position = target.position - transform.forward * dstFromTarget;
    }
}
