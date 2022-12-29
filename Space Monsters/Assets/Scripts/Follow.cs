using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform followTarget;
    [SerializeField] float lerpSpeed;

    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, followTarget.position, lerpSpeed);
    }
}
