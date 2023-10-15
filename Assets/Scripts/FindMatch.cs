using System.Collections;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class FindMatch : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Transform matchFoundTransform;

    [SerializeField] private InterpolatedComponent matchFound;
    [SerializeField] private InterpolatedComponent sliderBar;

    [SerializeField] private CanvasGroup mainMenuCanvasGroup;
    [SerializeField] private CanvasGroup champSelectCanvasGroup;

    public void PressButton()
    {
        matchFoundTransform.gameObject.SetActive(true);
        StartCoroutine(passToChampSelect());
        matchFound.AnimationInStart();
        sliderBar.AnimationInStart();
    }
    private IEnumerator moveSlider()
    {
        while (slider.value > .05)
        {
            slider.value -= Time.deltaTime/5;
            yield return null;
        }
    }
    private IEnumerator passToChampSelect()
    {
        yield return moveSlider();
        yield return MainMenuAnimations.Instance.AnimateMenuOut();
        StartCoroutine(mainMenuCanvasGroup.FadeAway());
        StartCoroutine(champSelectCanvasGroup.FadeIn());
        CharacterSelectManager.Instance.AnimateAllIn();
    }
}
