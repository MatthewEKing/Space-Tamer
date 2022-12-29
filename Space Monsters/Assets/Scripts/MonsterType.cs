using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Monster", menuName = "Create New Monster")]
public class MonsterType : ScriptableObject
{
    public int thirstMeterAmount;
    public float timeBetweenThirstDepletion;
    public float speed;

    public Sprite sprite;
}
