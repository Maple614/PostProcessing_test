using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using Cinemachine.PostFX;

public class PostProcessingStackFoVController : MonoBehaviour
{
    private CinemachinePostProcessing  m_CinemachinePostProcessing;
    public FloatParameter focusDistance;
    public FloatParameter aperture;
    public FloatParameter focalLength;

    PostProcessEffectSettings settings;
    DepthOfField dof;
    public GameObject vcam;
    // Start is called before the first frame update
    void Start()
    {
        m_CinemachinePostProcessing = GetComponent<CinemachinePostProcessing>();
        //Debug.Log($"{m_CinemachinePostProcessing.Profile.settings[0]}");
        
        foreach (var item in m_CinemachinePostProcessing.Profile.settings)
        {
            Debug.Log($"{item.GetType()}");
            Debug.Log($"{item}");
        }

        //dof = GetComponent<DepthOfField>();

        //var dof_ = ScriptableObject.CreateInstance<DepthOfField>();
        //dof_.focusDistance.Override(15);
        //PostProcessManager.instance.QuickVolume(null, 1, dof_);

    }

    // Update is called once per frame
    void Update()
    {
        //dof.focusDistance = focusDistance;
        //dof.aperture = aperture;
        //dof.focalLength = focalLength;
    }
}
