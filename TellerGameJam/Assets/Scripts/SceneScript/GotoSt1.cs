using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoSt1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Stage1");
        }//타이틀에서 1스테이지 갈때
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "st 1")
        {
            SceneManager.LoadScene("Stage1");
        }
    }
}
