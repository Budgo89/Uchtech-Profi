using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIView : MonoBehaviour
{
    [SerializeField] private Button _askButton;
    [SerializeField] private Button _startButton;
    [SerializeField] private TMP_InputField _axis1;
    [SerializeField] private TMP_InputField _axis2;

    public Button AskButton => _askButton;
    public Button StartButton => _startButton;
    public TMP_InputField Axis1 => _axis1;
    public TMP_InputField Axis2 => _axis2;

    public event Action OnButtonEnter;


    public void OnPointerEnter(PointerEventData eventData)
    {
        OnButtonEnter?.Invoke();
    }
}
