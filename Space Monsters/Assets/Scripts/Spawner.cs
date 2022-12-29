using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Planet planet;
    [SerializeField] int numberOfMonstersToSpawn;

    void Awake()
    {
        planet = GetComponentInParent<Planet>();
    }

    void Start()
    {
        
    }

    public void SpawnMonster(Monster monster)
    {
        Instantiate(monster.gameObject, transform.position, Quaternion.identity);
    }
}
