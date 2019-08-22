using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using Cinemachine.PostFX;

public class PostProcessingValueController : MonoBehaviour
{
    public enum SliderParameter
    {
        FocusDistance,
        Aperture,
        FocalLength
    }

    public SliderParameter sliderParameter;

    private CinemachinePostProcessing  m_CinemachinePostProcessing;
    public GameObject vcam;

    private DepthOfField m_Dof;

    // Start is called before the first frame update
    void Start()
    {
        m_CinemachinePostProcessing = vcam.GetComponent<CinemachinePostProcessing>();
        //Debug.Log($"{m_CinemachinePostProcessing.Profile.GetSetting<DepthOfField>()}");

        m_Dof = m_CinemachinePostProcessing.Profile.GetSetting<DepthOfField>();
    }

    public void ChangePostProcessValue(float value)
    {
        //FloatParameter floatParameter = new FloatParameter { value = slidervalue };

        switch (sliderParameter)
        {
            case SliderParameter.FocusDistance:
                m_Dof.focusDistance.value = value;
                break;
            case SliderParameter.Aperture:
                m_Dof.aperture.value = value;
                break;
            case SliderParameter.FocalLength:
                m_Dof.focalLength.value = value;
                break;
        }
    }

}
