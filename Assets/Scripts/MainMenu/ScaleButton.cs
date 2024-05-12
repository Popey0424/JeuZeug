using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScaleButton : MonoBehaviour
{
    private RectTransform myRectTransform; // J'insere le rect transform du boutton 
    private Vector3 originalScale;
    public float targetScale;
    public float TimeAnimation = 1.0f; // Durée de l'animation en secondes
    public void Scale()
    {
        StopAllCoroutines();
        StartCoroutine(ScaleOverTime());
    }

    private void Start()
    {
        myRectTransform = GetComponent<RectTransform>();//Ca prend le rectTransform de l'objet en question
        originalScale = myRectTransform.localScale; // Stocker l'échelle d'origine
    }
    private IEnumerator ScaleOverTime()
    {
        Vector3 startScale = myRectTransform.localScale;
        float elapsedTime = 0f;

        while (elapsedTime < TimeAnimation)
        {
            myRectTransform.localScale = Vector3.Lerp(startScale, new Vector3(targetScale, targetScale, targetScale), elapsedTime / TimeAnimation); // Gere le calcule entre 2 frame grace a la fct Lerp
            elapsedTime += Time.deltaTime;
            yield return null; // Attendre la prochaine trame
        }

        // Assurer que l'échelle atteint exactement la cible à la fin
    }

    private IEnumerator Reverse()
    {

        float duration = 1.0f; // Durée de l'animation en secondes
        float targetScale = 1.0f; // Échelle d'origine

        Vector3 startScale = myRectTransform.localScale;
        float elapsedTime = 0f;

        while (elapsedTime < TimeAnimation)
        {
            myRectTransform.localScale = Vector3.Lerp(startScale, new Vector3(originalScale.x, originalScale.y, originalScale.z), elapsedTime / TimeAnimation);
            elapsedTime += Time.deltaTime;
            yield return null; // Attendre la prochaine trame
        }

        // Assurer que l'échelle atteint exactement la cible à la fin
        myRectTransform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);
    }

    public void Default()
    {
        StopAllCoroutines(); //Ca arrete la courotines en haut sinon elle fonctionnera jamais
        StartCoroutine(Reverse());
        //myRectTransform.localScale = Vector3.one;
    }
}
