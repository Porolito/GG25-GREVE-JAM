using UnityEngine;

public class DropzoneManager : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ObjectController>().m_isDragged == false)
        {
            Destroy(collision.gameObject);
        }
    }
}
