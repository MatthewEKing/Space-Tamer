using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] PlantType type;
    [SerializeField] float offset = 10;
    //[SerializeField] float dropletSpeed = 5f;

    void OnTriggerEnter2D(Collider2D other)
    {

        //StartCoroutine(SpawnDroplets());

        for (int i = 0; i < type.amountOfDropsToSpawn; i++)
        {
            int randomInt = Random.Range(0, type.liquidTypes.Length);
            GameObject obj = Instantiate(type.liquidTypes[randomInt].gameObject, new Vector2(Random.Range(offset, -offset), Random.Range(offset, -offset)), Quaternion.identity);
        }

        Destroy(gameObject);
    }
    
    /* IEnumerator SpawnDroplets()
    {
        for (int i = 0; i < type.amountOfDropsToSpawn; i++)
        {
            int randomInt = Random.Range(0, type.liquidTypes.Length);
            GameObject obj = Instantiate(type.liquidTypes[randomInt].gameObject, transform.position, Quaternion.identity);
            obj.transform.position = Vector2.Lerp(transform.position, new Vector2(Random.Range(offset, -offset), Random.Range(offset, -offset)), dropletSpeed * Time.deltaTime);
            yield return new WaitForSeconds(3f);
        }

        Destroy(gameObject);
    } */

}
