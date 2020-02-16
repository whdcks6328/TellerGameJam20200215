using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float jump = 500f;
    [SerializeField] float skillTime;
    [SerializeField] float sCooldown = 0f;
    [SerializeField] bool isJumped = false;
    InputManager inputmanager;
    Rigidbody rb;
    [SerializeField] public bool isBGWhite = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sCooldown += Time.deltaTime;

        if (/*inputmanager.CheckJumped() == true */Input.GetKeyDown(KeyCode.Space) && isJumped == false) 
        { 
            rb.AddForce(jump * Time.deltaTime * Vector3.up, ForceMode.Impulse);
            isJumped = true;
        }
        if(Input.GetKeyDown(KeyCode.LeftControl) && sCooldown > 2f)
        {
            transform.Translate(10f * Time.deltaTime * Vector3.up);
            isJumped = true;
            skillTime = 1f;
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            isBGWhite = !isBGWhite;
            sCooldown = 0f;
        }
        if (skillTime > 0f)
        {
            skillTime -= Time.deltaTime;
            if (skillTime < 0f) { skillTime = 0f; }
        }
        else
        {
            rb.useGravity = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isJumped = false;
    }
}
