using UnityEngine;

public class CrowdCollision : MonoBehaviour
{
    [SerializeField] private CrowdMovement m_crowdMovement;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Lacrym") || collider.transform.CompareTag("Donut") & collider.GetComponent<ProjectileBehavior>().m_isMoving == true)
        {
            m_crowdMovement.HandleEnemyBounceBack();
        }
    }
}
