using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    public float JumpForce;
    
    void Start()
    {
        
    }

    void Update()
    {

        // Rigid.MoveRotation(Rigid.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * MouseSensitivity, 0)));
        // Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));
        

        //VR movement
        // bool triggerValue;
        // if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out triggerValue) && triggerValue){
            
        // }
    }
}
