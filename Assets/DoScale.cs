using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoScale : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    
    private void Start()
    {
        transform.DOScale(_endValue, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
