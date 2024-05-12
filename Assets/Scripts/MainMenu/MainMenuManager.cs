using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Image imageFade;

    [Header("Menus")]
    [SerializeField] private GameObject menuOptions;
    [SerializeField] private GameObject menuCredits;

   public void OnClickPlay()
    {
        imageFade.gameObject.SetActive(true);
        imageFade.DOFade(1, 2.9f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("GamePlay");
    }
}

