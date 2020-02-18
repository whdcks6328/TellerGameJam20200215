using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public Text stage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (stage.GetComponent<Text>().text == "Stage 1")
            {
                SceneManager.LoadScene("Stage1");
            }

            else if (stage.GetComponent<Text>().text == "Stage 2")
            {
                SceneManager.LoadScene("Stage2");
            }

            else if (stage.GetComponent<Text>().text == "Stage 3")
            {
                SceneManager.LoadScene("Stage3");
            }
        }
    }

}
