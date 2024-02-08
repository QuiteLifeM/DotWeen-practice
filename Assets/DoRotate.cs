using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _targetAxis;
    [SerializeField] private float _duration;
    private void Start()
    {
        transform.DORotate(_targetAxis, _duration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart);
    }
}
