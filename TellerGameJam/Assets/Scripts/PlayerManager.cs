using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float jump = 1f;
    [SerializeField] float skillTime;
    [SerializeField] float sCooldown = 0f;
    [SerializeField] float jCooldowm = 0f;
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
        sCooldown += Time.deltaTime;
        jCooldowm += Time.deltaTime;

        transform.Translate(speed * Time.deltaTime * Vector3.right);

        if(inputmanager.CheckJumped() == true && jCooldowm > 3f) 
        { 
            transform.Translate(jump * Time.deltaTime * Vector3.up);
            jCooldowm = 0f;
        }
        if(inputmanager.CheckColorChanged() == true && sCooldown > 0.5f)
        {
            transform.Translate(Time.deltaTime * Vector3.up);
            skillTime = 1f;
            rb.useGravity = false;
        }
        if (skillTime > 0f)
        {
            skillTime -= Time.deltaTime;
        }
        else
        {
            rb.useGravity = true;
            sCooldown = 0f;
        }
    }
}
