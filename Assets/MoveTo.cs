using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

public class MoveTo : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    
    private void Start()
    {
        transform.DOMove(_targetPosition, 3).SetLoops(-1, LoopType.Yoyo);
    }
}