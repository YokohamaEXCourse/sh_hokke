using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        score2=0;
    }

    // Update is called once per frame
    void Update()//ずっと
     {
        if(transform.position.x>25)
        {
            transform.position=new Vector3(-0.6f,1,0.11f);

            rb.AddForce(10, 0, 0,ForceMode.Impulse);

            rb.velocity=Vector3.zero;

            score2+=10;

            scoreText2.text=score2.ToString();

        }

        if(score2==50)
        {
            SceneManager.LoadScene("2Pwin");
        }
        if(transform.position.x<-30)
        {
            transform.position=new Vector3(-0.6f,1,0.11f);

            rb.AddForce(-10, 0, 0,ForceMode.Impulse);

            rb.velocity=Vector3.zero;

            score+=10;

            scoreText.text=score.ToString();

        }

        if(score==50)
        {
            SceneManager.LoadScene("1Pwin");
        }

     }
}