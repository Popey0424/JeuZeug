using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{

    [SerializeField] private Color ColorInitial;
    [SerializeField] private Color ColorSelected;
    [SerializeField] private TextMeshProUGUI text;

    public void OnPointerEnter()
    {
        

        text.DOKill();
        text.DOColor(ColorSelected, 0.2f);
    }

    public void OnPointerExit()
    {
        text.DOKill();
        text.DOColor(ColorInitial, 0.2f);
    }
}
