using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            if(transform.rotation.eulerAngles.y>=170)
            {
                transform.Rotate(new Vector3(0,-10,0));
            }
        }
    
          if(Input.GetKey(KeyCode.D))
    {
       //Debug.Log($"{transform.rotation.eulerAngles}");
        if(transform.rotation.eulerAngles.y<=190)
        {
            transform.Rotate(new Vector3(0,10,0));
        }
    }

         if(Input.GetKey(KeyCode.E))
        {
           transform.rotation=Quaternion.Euler(0f,180f,0f);
        }
    }
}