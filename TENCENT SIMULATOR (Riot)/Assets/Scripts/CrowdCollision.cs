using UnityEngine;

public class CrowdCollision : MonoBehaviour
{
    [SerializeField] private CrowdMovement m_crowdMovement;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Enemy"))
        {
            m_crowdMovement.HandleEnemyBounceBack();
        }
    }
}
