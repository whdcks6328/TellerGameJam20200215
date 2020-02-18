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
            SceneManager.LoadScene("Tutorial");
            Debug.Log("Checked");
    }
    public void OnClickLeft()
    {
            if (selectSt.GetComponent<Text>().text == "Stage 3")
            {
                selectSt.GetComponent<Text>().text = "Stage 2";
            }

            else if (selectSt.GetComponent<Text>().text == "Stage 2")
            {
                selectSt.GetComponent<Text>().text = "Stage 1";
            }
            Debug.Log("Checked");
    }

    public void OnClickRight()
    {
            Debug.Log("Checked");
            if (selectSt.GetComponent<Text>().text == "Stage 1")
            {
                selectSt.GetComponent<Text>().text = "Stage 2";
            }

            else if (selectSt.GetComponent<Text>().text == "Stage 2")
            {
                selectSt.GetComponent<Text>().text = "Stage 3";
            }
    }

    public void StageSelect()
    {
            Debug.Log("Checked");
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

    public void GameExit()
    {
            Debug.Log("Checked");
            Application.Quit();
    }
}
