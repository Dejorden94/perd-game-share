using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseAnimation : MonoBehaviour
{

    //Bron: https://www.youtube.com/watch?v=q-FPR1I2B74
    //Kanaal: Alex Voxel
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
