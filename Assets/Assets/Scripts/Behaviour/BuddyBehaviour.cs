using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyBehaviour : MonoBehaviour
{

    public float speed;
    public float jumpCeil;
    public float jumpPower;
    public GameObject target;
    bool jumping;

    void Start()
    {
        
    }

    void Update()
    {
        //Bouncy
        if (transform.position.y <= 0.6f) jumping = true;
        if (jumping){
            GetComponent<Rigidbody>().mass = 0.001f;
            transform.position += new Vector3(0f, jumpPower, 0f) * Time.deltaTime;
            if (transform.position.y >= jumpCeil){
                jumping = false;
                GetComponent<Rigidbody>().mass = 1f;
            }
        }

        //Seek and destroy

        float x = 0;
        float z = 0;
        if (transform.position.x > target.transform.position.x){
            x = -speed;
        } else if (transform.position.z > target.transform.position.z){
            z = -speed;
        } else if (transform.position.x < target.transform.position.x){
            x = speed;
        } else if (transform.position.z < target.transform.position.z){
            z = speed;
        }

        transform.position += new Vector3(x, 0f, z) * Time.deltaTime;

    }

    void OnCollisionEnter(Collision c){
        if (c.gameObject.tag == "Ground"){
            jumping = false;
        }
    }
}
