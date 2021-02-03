using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform ballMonokumaPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ballMonokumaPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, ballMonokumaPos.position.y, transform.position.z);
        }
    }
}
