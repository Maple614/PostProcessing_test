using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Cinemachine.PostFX;

public class PostProcessingSwitcher : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCameraBase m_vCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void PostProcessingSwitch()
    {
        var postProcessing = this.m_vCam.GetComponent<CinemachinePostProcessing>();
        postProcessing.enabled = !postProcessing.enabled;
    }
}
