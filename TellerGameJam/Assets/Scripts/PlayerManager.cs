using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] float jump = 500f;
    [SerializeField] float skillTime;
    [SerializeField] float sCooldown = 0f;
    bool isJumped = false;
    bool isChanging = false;
    InputManager inputmanager;
    Rigidbody rb;
    AudioSource audioSource;
    [SerializeField] public bool isBGWhite = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sCooldown += Time.deltaTime;

        if (!Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Space) && isJumped == false) 
        { 
            rb.AddForce(jump * Time.deltaTime * Vector3.up, ForceMode.Impulse);
            isJumped = true;
        }
        if(Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.Space) && !isChanging)
        {
            //약간의 호버링
            transform.Translate(10f * Time.deltaTime * Vector3.up);
            //추가점프 봉인, 추가 변경 봉인(땅에 닿으면 풀림)
            isJumped = true;
            isChanging = true;
            //무중력 돌임
            skillTime = 1f;
            rb.useGravity = false;
            //점프중이었다면 속도 고정
            rb.velocity = Vector3.zero;
            //색 변경
            isBGWhite = !isBGWhite;
            sCooldown = 0f;

            //Audio Play
            audioSource.Play();
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
        isChanging = false;
    }
}
