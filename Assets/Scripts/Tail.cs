using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public Transform networkOwner;
    public Transform followTransform;

    [SerializeField] private float delayTime = 0.13f;
    [SerializeField] private float distance = 0.3f;
    [SerializeField] private float moveStep = 10f;

    private Vector3 _targetposition;

    private void Update()
    {
        _targetposition = followTransform.position - followTransform.forward * distance;
        _targetposition += (transform.position - transform.position) * delayTime;
        _targetposition.z = 0f;

        transform.position = Vector3.Lerp(transform.position, _targetposition, Time.deltaTime * moveStep);
    }
}
