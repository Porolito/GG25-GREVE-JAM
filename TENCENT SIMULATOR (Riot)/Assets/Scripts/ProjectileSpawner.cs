using System.Collections;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] float m_spawnTime;
    [SerializeField] Transform m_spawnPosition;

    [SerializeField] GameObject m_ProjectileGO;

    [SerializeField] Transform anchor0, control0, control1, anchor1;

    private void Start()
    {
        StartCoroutine(SpawnNewProjectile());
    }

    IEnumerator SpawnNewProjectile() 
    {
        while (true)
        {
            yield return new WaitForSeconds(m_spawnTime);
            GameObject newProj = Instantiate(m_ProjectileGO, m_spawnPosition);
            newProj.GetComponent<ProjectileBehavior>().Init(anchor0, control0, control1, anchor1);
        }
    }
}
