using System.Collections;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] float m_spawnTime;
    [SerializeField] Transform m_spawnPosition;

    [SerializeField] GameObject m_ProjectileGO;

    private void Start()
    {
        StartCoroutine(SpawnNewProjectile());
    }

    IEnumerator SpawnNewProjectile() 
    {
        while (true) 
        {
            yield return new WaitForSeconds(m_spawnTime);
            Instantiate(m_ProjectileGO,m_spawnPosition);
        }
        
    }
}
