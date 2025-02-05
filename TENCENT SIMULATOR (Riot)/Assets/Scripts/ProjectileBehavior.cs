using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    Transform[] points = new Transform[4];

    [SerializeField] float m_projSpeed;

    [SerializeField] Transform m_projectileTransform;

    public bool m_isMoving = true;

    float T;

    Vector2 BezierCubicAlgorithm(float currentT)
    {
        Vector2 a = Vector2.Lerp(points[0].position, points[1].position, currentT);
        Vector2 b = Vector2.Lerp(points[1].position, points[2].position, currentT);
        Vector2 c = Vector2.Lerp(points[2].position, points[3].position, currentT);
        Vector2 d = Vector2.Lerp(a, b, currentT);
        Vector2 e = Vector2.Lerp(b, c, currentT);

        return Vector2.Lerp(d, e, currentT);
    }

    public void Init(Transform anchor0, Transform control0, Transform control1, Transform anchor1, float speed)
    {
        points[0] = anchor0;
        points[1] = control0;
        points[2] = control1;
        points[3] = anchor1;

        m_projSpeed = speed;
    }

    private void Update()
    {
        if (m_isMoving)
        {
            m_projectileTransform.position = BezierCubicAlgorithm(T);
            T += Time.deltaTime * m_projSpeed;
            if (T >= 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
