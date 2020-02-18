using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarGroupRotateter : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 180f * Time.deltaTime);
    }
}
