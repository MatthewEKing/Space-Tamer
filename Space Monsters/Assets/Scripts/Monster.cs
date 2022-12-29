using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] MonsterType monster;
    Ship ship;
    Transform followObj;


    [Header("Thirst Mechanic")]
    int thirstMeter;
    float thirstTimer;
    float timeBetweenThirstDepletion;

    [Header("Movement")]
    float speed;
    float lerpDuration = 5f;
    float elapsedTime;
    bool isFollowing = false;

    void Awake()
    {
        SetUpMonsterStats();
    }

    void Update()
    {
        ManageThirst();
        Follow();
    }

    void ManageThirst()
    {
        thirstTimer -= Time.deltaTime;
        if (thirstTimer <= 0f)
        {
            thirstMeter--;
            Debug.Log("Thirst Depleted");
            thirstTimer = timeBetweenThirstDepletion;
        }

        if (thirstMeter <= 0)
        {
            Destroy(gameObject);
        }
    }

    void SetUpMonsterStats()
    {
        thirstTimer = monster.timeBetweenThirstDepletion;
        thirstMeter = monster.thirstMeterAmount;
        timeBetweenThirstDepletion = monster.timeBetweenThirstDepletion;
        speed = monster.speed;
    }

    void Follow()
    {
        if (isFollowing)
        {
            // += Time.deltaTime;
            //float lerpPercentage = elapsedTime / lerpDuration;
            transform.position = Vector2.Lerp(transform.position, followObj.position, speed * Time.deltaTime);
        }
    }

    public void Drink()
    {
        thirstMeter++;
    }

    public void StartFollowing(Transform obj)
    {
        followObj = obj;
        isFollowing = true;
    }

    public bool CheckIsFollowing()
    {
        return isFollowing;
    }
}
