using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーンマネージャーを読み込む命令

public class Buttonscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene"); //シーンを「SampleScene」に切り替える命令
    }
}