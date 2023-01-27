using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 0.3f;

    private bool rotate;

    // Start is called before the first frame update
    
    void Start()
    
    {
    
    
    }

    // Update is called once per frame
    
    void Update()
    
    {
        if (Input.GetKey(KeyCode.R))
        {
            rotate = true;
        }
        else
        {
            rotate = false;
        }
    }
    
    void FixedUpdate()
    
    {
        if (rotate)
        {
            this.GetComponent<Transform>().Rotate(0, rotationSpeed, 0);
        }
        
    }
}
