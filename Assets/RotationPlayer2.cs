using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log($"{transform.rotation.eulerAngles}");
            if(transform.rotation.eulerAngles.y>=170)
            {
            transform.Rotate(new Vector3(0,-10,0));
            }
        }
        if(Input.GetKey(KeyCode.RightArrow))
    {
       //Debug.Log($"{transform.rotation.eulerAngles}");
        if(transform.rotation.eulerAngles.y<=190)
        {
            transform.Rotate(new Vector3(0,10,0));
        }
    }

     if(Input.GetKey(KeyCode.Return))
        {
           transform.rotation=Quaternion.Euler(0f,180f,0f);
        }
}   
}
