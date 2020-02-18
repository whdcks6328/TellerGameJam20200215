using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenesManager: MonoBehaviour
{
    public GameObject selectSt;
    // Start is called before the first frame update
    void Start()
    {
        selectSt = GameObject.Find("StageNum");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Tutorial");
        }
    }
    public void OnClickLeft()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (selectSt.GetComponent<Text>().text == "Stage 3")
            {
                selectSt.GetComponent<Text>().text = "Stage 2";
            }

            else if (selectSt.GetComponent<Text>().text == "Stage 2")
            {
                selectSt.GetComponent<Text>().text = "Stage 1";
            }
        }
    }

    public void OnClickRight()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (selectSt.GetComponent<Text>().text == "Stage 1")
            {
                selectSt.GetComponent<Text>().text = "Stage 2";
            }

            else if (selectSt.GetComponent<Text>().text == "Stage 2")
            {
                selectSt.GetComponent<Text>().text = "Stage 3";
            }
        }
    }

    public void StageSelect()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (selectSt.GetComponent<Text>().text == "Stage 1")
            {
                SceneManager.LoadScene("Stage1");
            }

            else if (selectSt.GetComponent<Text>().text == "Stage 2")
            {
                SceneManager.LoadScene("Stage2");
            }

            else if (selectSt.GetComponent<Text>().text == "Stage 3")
            {
                SceneManager.LoadScene("Stage3");
            }
        }
    }

    public void GameExit()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}
