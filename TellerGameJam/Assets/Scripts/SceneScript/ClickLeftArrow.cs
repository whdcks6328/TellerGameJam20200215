using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLeftArrow : MonoBehaviour
{
    public Text stage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickLeft()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (stage.GetComponent<Text>().text == "Stage 3")
            {
                stage.GetComponent<Text>().text = "Stage 2";
            }

            else if (stage.GetComponent<Text>().text == "Stage 2")
            {
                stage.GetComponent<Text>().text = "Stage 1";
            }
        }
    }
}
