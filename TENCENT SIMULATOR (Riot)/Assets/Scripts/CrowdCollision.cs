using UnityEngine;

public class CrowdCollision : MonoBehaviour
{
    [SerializeField] private CrowdMovement m_crowdMovement;

    [SerializeField] private PlayerScore m_PlayerScore;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Lacrym") || collider.transform.CompareTag("Donut") & collider.GetComponent<ProjectileBehavior>().m_isMoving == true)
        {
            m_PlayerScore.BreakCombo();
            m_PlayerScore.MinusScore(100);
            m_crowdMovement.HandleEnemyBounceBack();
        }
    }
}
