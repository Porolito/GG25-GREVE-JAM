using UnityEngine;

public class DropzoneManager : MonoBehaviour
{
    [SerializeField] private EN_DropzoneType m_Type;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectController>().m_isDragged == false)
        {
            if (collision.gameObject.tag == m_Type.ToString())
            {
                Destroy(collision.gameObject);
            }
            if (collision.gameObject.tag == m_Type.ToString())
            {
                Destroy(collision.gameObject);
            }
            else
            {
                Debug.Log("Wrong dropzone");
                //TODO : Implement minus score if wrong dropzone
            }
        }
    }
}
