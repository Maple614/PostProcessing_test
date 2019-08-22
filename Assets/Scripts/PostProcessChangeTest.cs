using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine.PostFX;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessChangeTest : MonoBehaviour
{
    public FloatParameter FocusDistance;
    public FloatParameter Aperture;
    public FloatParameter FocalLength;

    CinemachinePostProcessing m_CinemachinePostProcessing;
    DepthOfField dof;

    // Start is called before the first frame update
    void Start()
    {
        m_CinemachinePostProcessing = GetComponent<CinemachinePostProcessing>();
        dof = m_CinemachinePostProcessing.Profile.GetSetting<DepthOfField>();
    }

    // Update is called once per frame
    void Update()
    {
        dof.focusDistance = FocusDistance;
        dof.aperture = Aperture;
        dof.focalLength = FocusDistance;
    }
}
