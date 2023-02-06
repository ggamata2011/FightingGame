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
    private Vector3 LeftBoundary = new Vector3(1.808f, 0.368f, 16.18076f);
    private Vector3 RightBoundary = new Vector3(1.808f, 0.368f, 6.939383f);

    //Health Variables
    public int MAXHEALTH = 1000;
    public int PlayerHealth;

    public HealthBar P1HealthBar;
   

    private Rigidbody ApplyForceTo;
    private CapsuleCollider CharacterBox;

    // Start is called before the first frame update
    void Start()
    {
        //Get RigidBody Component
        ApplyForceTo = GetComponent<Rigidbody>();
        CharacterBox = GetComponent<CapsuleCollider>();

        //Set Max Health of Player Character
        PlayerHealth = MAXHEALTH;
        P1HealthBar.MaxHealth(MAXHEALTH);

    }

    // Update is called once per frame
    void Update()
    {
        //Get PlayerInput
        HorizontalMovement = Input.GetAxis("Horizontal");

        if(CheckBound(LeftBoundary,RightBoundary,transform.position))
        {
            //Move Player Forward 
            transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed * HorizontalMovement);
        }
        else if(HorizontalMovement >= 0){
           transform.Translate(Vector3.forward * Time.deltaTime * MovementSpeed * HorizontalMovement);
        }
        
        //Jump Button
        if(Input.GetKeyDown(KeyCode.W))
        {
            ApplyForceTo.AddForce(Vector3.up * 700,ForceMode.Impulse);
            
        }

        //Test Function for taking Damage and chaning the health bar
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(45);
        }

    }

    //Used to check boundaries of player character
    bool CheckBound(Vector3 leftbound,Vector3 rightbound,Vector3 position)
    {
        //placeholder return for checking boundaries
        return (position.z <= leftbound.z) && (position.z >= rightbound.z);

    }

    void TakeDamage(int dmg)
    {
        PlayerHealth = PlayerHealth - dmg;
        P1HealthBar.SetHealth(PlayerHealth);
    }

}
