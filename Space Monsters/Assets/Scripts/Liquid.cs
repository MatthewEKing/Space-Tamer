using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liquid : MonoBehaviour
{
    public float liquidAmount;

    [SerializeField] float timeUntilCollectable = .5f;
    [SerializeField] bool isCollectable = false;

    void Start()
    {
        StartCoroutine(SetIsCollectable());
    }

    IEnumerator SetIsCollectable()
    {
        isCollectable = false;
        yield return new WaitForSeconds(timeUntilCollectable);
        isCollectable = true;
    }

    public bool CheckIsCollectable()
    {
        return isCollectable;
    }
}
