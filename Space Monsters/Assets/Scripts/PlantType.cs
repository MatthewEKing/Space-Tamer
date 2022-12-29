using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Plant", menuName = "Create New Plant")]
public class PlantType : ScriptableObject
{
    public Liquid[] liquidTypes;
    public int amountOfDropsToSpawn;
}
