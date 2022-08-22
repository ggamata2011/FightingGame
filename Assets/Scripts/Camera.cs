using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;
    private Vector3 CameraPos = new Vector3(0, 0, 0);
    private Vector3 offset = new Vector3(-3.138f, 1.66f, -3.63f);
    

    void Start()
    {
        transform.position = player1.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        //Update Camera Position in relation to characters
        transform.position = GetMidoint(player1.transform.position, player2.transform.position, offset);
    }

    
    Vector3 GetMidoint(Vector3 P1, Vector3 P2, Vector3 Offset)
    {
        //Instantiate Midpoint Variable
        Vector3 MidPoint = new Vector3(0, 0, 0);

        //Set Midpoint currently as our default camera angle
        MidPoint = transform.position;

        //Offset z position to get midpoint between two players
        MidPoint.z = ((P1.z + P2.z) / 2.0f);


        return MidPoint;
    }
    
}
