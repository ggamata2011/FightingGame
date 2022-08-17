using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    //Variables
    private float MovementSpeed = 3.0f;
    private float JumpHeight = 40.0f;
    private float HorizontalMovement;
    private float JumpMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get PlayerInput
        HorizontalMovement = Input.GetAxis("Horizontal");
        

        //Move Player Forward 
        transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed * HorizontalMovement);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * JumpHeight);
        }

    }
}
