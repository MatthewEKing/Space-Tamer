using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Planet", menuName = "Create New Planet")]
public class PlanetType : ScriptableObject
{
    public Monster[] monsterTypesToSpawn;
    public Plant[] plantTypesToSpawn;
}
