using UnityEngine;

public class CrowdManager : MonoBehaviour
{
    [SerializeField] Transform m_CrowdTransform;

    float m_CrowdProgress;
    float m_CrowdBaseSpeed = -0.001f;
    float m_CrowdProgressMultiplier;

    void Update()
    {
        m_CrowdTransform.Translate(m_CrowdBaseSpeed, 0, 0);
    }
}
