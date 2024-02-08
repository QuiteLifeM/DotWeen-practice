using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DoText : MonoBehaviour
{
    [SerializeField] private Text _textToReplace;
    [SerializeField] private Text _textToAdd;
    [SerializeField] private Text _textToScramble;
    [SerializeField] private float _duration;

    private void Start()    
    {
        _textToReplace.DOText("Это было не просто смело. Это было пиздец как смело.", _duration);
        _textToAdd.DOText(" Сомнительно, но Окэээй.", _duration).SetRelative();
        _textToScramble.DOText("Ну это пиздец какой-то просто, ну сколько можно.", _duration, true, ScrambleMode.All);
    }
}