using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement: MonoBehaviour
{

    //Variables
    private float MovementSpeed = 3.0f;
    private float JumpHeight = 40.0f;
    private float HorizontalMovement;
    private float JumpMovement;
    private Vector3 LeftBoundary = new Vector3(1.808f, 0.368f, 16.18076f);
    private Vector3 RightBoundary = new Vector3(1.808f, 0.368f, 6.939383f);

    private Rigidbody ApplyForceTo;


    // Start is called before the first frame update
    void Start()
    {
        //Get RigidBody Component
        ApplyForceTo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get PlayerInput
        HorizontalMovement = Input.GetAxis("HorizontalP2");

        if (CheckBound(LeftBoundary, RightBoundary, transform.position))
        {
            //Move Player Forward 
            transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed * HorizontalMovement*(-1));
        }
        else if (HorizontalMovement >= 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed * HorizontalMovement*(-1));
        }



         if (Input.GetKeyDown(KeyCode.I))
         {
              ApplyForceTo.AddForce(Vector3.up * 700,ForceMode.Impulse);
         }
        
    }


    //Used to check boundaries of player character
    bool CheckBound(Vector3 leftbound, Vector3 rightbound, Vector3 position)
    {
        //placeholder return for checking boundaries
        return (position.z <= leftbound.z) && (position.z >= rightbound.z);

    }
}
