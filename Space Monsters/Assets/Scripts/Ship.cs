using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Monster> monsters;
    public Transform[] slotArray;

    [Header("Thirst Mechanic")]
    [SerializeField] float liquidAmount;
    [SerializeField] float maxLiquidAmount;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckForNullSlots();
            foreach (Monster monster in monsters)
            {
                monster.Drink();
                liquidAmount--;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Monster>() != null)
        {
            Monster monster = other.GetComponent<Monster>();
            if (monster.CheckIsFollowing()) { return; }

            if (monsters.Count <= 2)
            {
                CheckForNullSlots();
                monsters.Add(monster);
            }
            else
            {
                Debug.Log("Max Monsters");
                /* CheckForNullSlots();
                monsters.Remove(monsters[monsters.Count - 1]);
                monsters.Add(monster);
                Debug.Log(monsters[0]); */
            }

            SetMonsterFollowPoints();
        }

        if (other.GetComponent<Liquid>() != null)
        {
            Liquid liquid = other.GetComponent<Liquid>();

            if (liquid.CheckIsCollectable())
            {
                AddLiquid(liquid.liquidAmount);
                Destroy(other.gameObject);
            }
        }
    }

    void SetMonsterFollowPoints()
    {
        for (int i = 0; i < monsters.Count; i++)
        {
            monsters[i].StartFollowing(slotArray[i]);
        }
    }


    void CheckForNullSlots()
    {
        for (int i = 0; i < monsters.Count; i++)
        {
            if (monsters[i] == null)
            {
                monsters.Remove(monsters[i]);
                i = 0;
            }
        }
    }
    
    void AddLiquid(float amount)
    {
        liquidAmount += amount;
    }
}