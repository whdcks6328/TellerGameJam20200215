using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoSt3 : MonoBehaviour
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
            SceneManager.LoadScene("Stage3");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "st 1")
        {
            SceneManager.LoadScene("Stage3");
        }
    }
}
