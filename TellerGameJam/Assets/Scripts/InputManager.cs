using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool CheckJumped()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
    public bool CheckColorChanged()
    {
        return Input.GetKeyDown(KeyCode.LeftControl);
    }
}
