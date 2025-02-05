using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] float m_spawnTime;
    [SerializeField] Transform m_spawnPosition;

    [SerializeField] GameObject m_ProjectileGO_Lacrym;
    [SerializeField] GameObject m_ProjectileGO_Donut;

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
            int random = Random.Range(0,2);
            GameObject newProj = Instantiate((random == 0 ? m_ProjectileGO_Lacrym : m_ProjectileGO_Donut), m_spawnPosition);
            newProj.GetComponent<ProjectileBehavior>().Init(anchor0, control0, control1, anchor1, Random.Range(0.3f, 0.6f));
        }
    }
}
