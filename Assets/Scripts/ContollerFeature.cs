using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class ContollerFeature : MonoBehaviour
{
    public XRNode m_controller;
    private InputDevice m_inputDevice;
    public UnityEvent PressEvent;
    public UnityEvent ReleaseEvent;

    void Start()
    {
        m_inputDevice = InputDevices.GetDeviceAtXRNode(m_controller); //get controller node (Left or Right)
    }

    void Update()
    {
        bool gripbutton; // state grip button
        if(m_inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out gripbutton) && gripbutton) // if grip button press
        {
            PressEvent.Invoke();
        }
        
        if(m_inputDevice.TryGetFeatureValue(CommonUsages.gripButton, out gripbutton) && !gripbutton) // if grip button release
        {
            ReleaseEvent.Invoke();
        }
    }
}
