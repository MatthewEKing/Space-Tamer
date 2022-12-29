using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    PlanetType type;
    [SerializeField] Spawner spawner;

    void Awake()
    {
        spawner = GetComponentInChildren<Spawner>();
    }

    void Start()
    {
        
    }
}
