using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject m_PrfbEntity;
    public SpawnEntity m_SpawnEntity;    

    void Start()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        for (int i = 0; i < m_SpawnEntity.positions.Length; i++)
        {
            GameObject currentEntity
                = Instantiate(m_PrfbEntity, m_SpawnEntity.positions[i], Quaternion.identity);
            currentEntity.name = m_SpawnEntity.name + i;
        }
    }
}
