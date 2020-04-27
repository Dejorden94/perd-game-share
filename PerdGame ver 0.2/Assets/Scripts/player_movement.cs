using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Bron: https://www.youtube.com/watch?v=sXQI_0ILEW4
//Kanaal: Aaron Hibberd 

public class player_movement : MonoBehaviour
{
    public moodSwitch script;
    public float walkSpeed = 2;
    public float runSpeed = 6;

    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    public float speedSmoothTime = 0.1f;
    float speedSmoothVelocity;
    float currentSpeed;
    Transform cameraT;

    public int count;

    public Text scoreText;

    public Transform target1;

    public Transform target2;

    public Transform target3;

    public Transform target4;
   void Start() {
       cameraT = Camera.main.transform;
       count = 0;
       SetCountText ();
   }
   void FixedUpdate() {
       Vector2 input = new Vector2(Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw("Vertical"));
       Vector2 inputDir = input.normalized;
       if (inputDir != Vector2.zero){
           float targetRotation = Mathf.Atan2 (inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraT.eulerAngles.y;
           transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
       //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
       }
    	bool running = Input.GetKey (KeyCode.LeftShift);
        float targetSpeed = ((running)? runSpeed : walkSpeed) * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp (currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

        transform.Translate (transform.forward * currentSpeed * Time.deltaTime, Space.World);

   }
   void OnTriggerEnter(Collider other) {
       missionWaypoint nextPoint = GameObject.Find("Waypoint").GetComponent<missionWaypoint>(); 
            if (other.gameObject.tag == "Points")
            {
                count = count + 100;
                //Debug.Log("Vernedering");
                SetCountText ();
                script.SetImage();
            }
            else if (other.gameObject.tag == "Objective1")
            {
                Debug.Log("Objective 1");
                other.gameObject.GetComponent<MeshRenderer>().enabled = false;
                other.gameObject.GetComponent<SphereCollider>().enabled = false;
                GameObject.Find("Waypoint").GetComponent<Image>().enabled = false;
                
            }
   }
    void SetCountText ()
    {
        scoreText.text = "Vernederings punten " + count.ToString();
    }
}
