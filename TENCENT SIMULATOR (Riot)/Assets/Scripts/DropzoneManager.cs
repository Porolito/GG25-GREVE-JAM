using TMPro;
using UnityEngine;

public class DropzoneManager : MonoBehaviour
{
    [SerializeField] private EN_DropzoneType m_Type;

    [SerializeField] private PlayerScore m_PlayerScore;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectController>().m_isDragged == false)
        {
            if (collision.gameObject.tag == m_Type.ToString())
            {
                m_PlayerScore.AddCombo();
                m_PlayerScore.AddScore(50);
                Destroy(collision.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
                Debug.Log("Wrong dropzone");
                m_PlayerScore.BreakCombo();
                m_PlayerScore.MinusScore(50);
                //TODO : Implement minus score if wrong dropzone
            }
        }
    }
}
