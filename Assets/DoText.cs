using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DoText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;
    [SerializeField] private float _duration;

    private void Start()    
    {
        _text1.DOText("Это было не просто смело. Это было пиздец как смело.", _duration);
        _text2.DOText(" Сомнительно, но Окэээй.", _duration).SetRelative();
        _text3.DOText("Ну это пиздец какой-то просто, ну сколько можно.", _duration, true, ScrambleMode.All);
    }

    private void Awake()
    {
        _text1
    }
}