using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Image imageFade;

    [Header("AnimationSetteings")]
    public Animator MenuFriendList;

    [Header("Menus")]
    [SerializeField] private GameObject menuOptions;
    [SerializeField] private GameObject menuCredits;
    [SerializeField] private GameObject menuFriendList;

   public void OnClickPlay()
    {
        imageFade.gameObject.SetActive(true);
        imageFade.DOFade(1, 2.9f).OnComplete(FadeComplete);
    }

    private void FadeComplete()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void OnClickFriendList()
    {
        Animator animator_FriendList = menuFriendList.GetComponent<Animator>();
        if (animator_FriendList != null )
        {
            bool IsOpen = animator_FriendList.GetBool("OpenFriendList");

            animator_FriendList.SetBool("OpenFriendList", true);
        }
    }

    public void OnLeaveFriendList()
    {
        Animator animator_FriendList = menuFriendList.GetComponent<Animator>();
        if (animator_FriendList != null)
        {
            bool IsOpen = animator_FriendList.GetBool("OpenFriendList");

            animator_FriendList.SetBool("OpenFriendList", false);
        }
    }
}

