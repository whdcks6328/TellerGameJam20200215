using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jump;
    [SerializeField] float flingTime;
    float skillTime;
    float cooldown;
    InputManager inputmanager;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Vector3.right);

        if (inputmanager.CheckJumped() == true)
        {
            transform.Translate(jump * Vector3.up);
        }

        if (inputmanager.CheckColorChanged() == true)
        {
            transform.Translate(Vector3.up);
            skillTime = 1f;
            rb.useGravity = false;
        }
        if (skillTime > 0)
        {
            skillTime -= Time.deltaTime;
        }
        else rb.useGravity = true;
    }
}