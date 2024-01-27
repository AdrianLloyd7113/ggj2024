using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerControl : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {

        //TODO: Keyboard/mouse movement

        //VR movement
        bool triggerValue;
        if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out triggerValue) && triggerValue){
            
        }
    }
}
