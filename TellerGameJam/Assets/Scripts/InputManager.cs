using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool CheckJumped()//점프 눌렸는지 확인.
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
    public bool CheckColorChanged()//색 변화 키 눌렸는지 확인
    {
        return Input.GetKeyDown(KeyCode.LeftControl);
    }
}
