using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using Cinemachine.PostFX;

public class PostProcessingSet : MonoBehaviour
{

    private CinemachinePostProcessing m_CinemachinePostProcessing;
    private DepthOfField m_Dof;

    public PostProcessProfile profile;
    // Start is called before the first frame update
    void Start()
    {
        m_CinemachinePostProcessing
            = this.gameObject.AddComponent<CinemachinePostProcessing>();

        m_CinemachinePostProcessing.m_FocusTracksTarget = true;

        m_CinemachinePostProcessing.m_Profile = profile;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
