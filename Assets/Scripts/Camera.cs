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
       
    }

    // Update is called once per frame
    void Update()
    {
        //Update Camera Position in relation to characters
        transform.position = GetMidoint(player1.transform.position, player2.transform.position, offset);
    }

    
    Vector3 GetMidoint(Vector3 P1, Vector3 P2, Vector3 Offset)
    {
        Vector3 MidPoint = new Vector3(0, 0, 0);
        MidPoint = P1 + offset;
        MidPoint.z = ((P1.z + P2.z) / 2.0f);
        return MidPoint;
    }
    
}
