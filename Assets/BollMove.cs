using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BollMove : MonoBehaviour
{
    public Rigidbody rb;
    private int score;
    private int score2;
    public Text scoreText;
    public Text scoreText2;

    void Start()
    {
        rb.AddForce(10, 0, 0,ForceMode.Impulse);
        score=0;
    }

    // Update is called once per frame
    void Update()//ずっと
    {
       if(transform.position.x>25)
       {
           transform.position=new Vector3(-0.6f,1,0.11f);

           scoreText.text=score.ToString();

            score+=10;
       }
       if(transform.position.x<-30)
       {
           transform.position=new Vector3(-0.6f,1,0.11f);

           scoreText2.text=score.ToString();

            score+=10;
       }
    }
}