using UnityEngine;

public class CrowdMovement : MonoBehaviour
{
    [SerializeField] Transform m_CrowdTransform;

    [SerializeField] float m_CrowdBaseSpeed = -0.001f;

    [SerializeField, Range(0,100)] float m_BounceBackSpeed;

    [SerializeField] float m_BounceDistance;

    float m_CrowdProgress;

    float m_CrowdProgressMultiplier;

    Vector3 m_BounceFinalPosition;

    bool m_inBounce;

    float m_currentBounceTimer = 0;

    void Update()
    {
        m_CrowdTransform.Translate(m_CrowdBaseSpeed * Time.deltaTime, 0, 0);

        if (m_inBounce)
        {
            UpdateLerpBouncePosition();
        }
    }

    public void HandleEnemyBounceBack()
    {
        m_BounceFinalPosition = m_CrowdTransform.position;
        m_BounceFinalPosition.x += m_BounceDistance;
        m_inBounce = true;
    }

    void UpdateLerpBouncePosition()
    {
        m_CrowdTransform.position = Vector3.Lerp(m_CrowdTransform.position, m_BounceFinalPosition, Time.deltaTime * m_BounceBackSpeed);
        m_currentBounceTimer += Time.deltaTime * m_BounceBackSpeed;
        if(m_currentBounceTimer >= 1)
        {
            m_inBounce = false;
            m_currentBounceTimer = 0;
        }
    }
}
