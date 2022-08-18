using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;

    private Vector3 offset = new Vector3(-3.138f, 1.66f, -3.63f);
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            transform.position = player1.transform.position + offset;
    }
}
