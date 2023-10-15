using System.Collections;
using UnityEngine;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class MainMenuAnimations : MonoBehaviour
{
    [SerializeField] private Transform featuredSkinsTransform;
    private InterpolatedComponent[] featuredSkins;

    [SerializeField] private InterpolatedComponent featuredText;
    [SerializeField] private InterpolatedComponent featuredLine;
    [SerializeField] private InterpolatedComponent playerIcon;
    [SerializeField] private InterpolatedComponent playerDetails;
    [SerializeField] private InterpolatedComponent playerLevelText;
    [SerializeField] private InterpolatedComponent playerLevelBar;

    [SerializeField] private InterpolatedComponent sideBar;
    [SerializeField] private InterpolatedComponent friendListPopUp;

    public static MainMenuAnimations Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    private void Start()
    {
        featuredSkins=featuredSkinsTransform.GetComponentsInChildren<InterpolatedComponent>();
        StartCoroutine(animateMenu());
    }
    private IEnumerator animateMenu()
    {
        foreach (var child in featuredSkins)
        {
            child.AnimationInStart();
            yield return new WaitForSeconds(.3f);
        }
        playerIcon.AnimationInStart();
        yield return new WaitForSeconds(.3f);
        featuredText.AnimationInStart();
        sideBar.AnimationInStart();
        yield return new WaitForSeconds(.1f);        
        featuredLine.AnimationInStart();
        yield return new WaitForSeconds(.1f);
        playerDetails.AnimationInStart();
        yield return new WaitForSeconds(.2f);
        playerLevelText.AnimationInStart();
        yield return new WaitForSeconds(.3f);
        playerLevelBar.AnimationInStart();
        yield return new WaitForSeconds(.3f);
        friendListPopUp.AnimationInStart();
    }
    public IEnumerator AnimateMenuOut()
    {
        foreach (var child in featuredSkins)
        {
            child.AnimationOutStart();
            yield return new WaitForSeconds(.2f);
        }
        playerIcon.AnimationOutStart();
        featuredText.AnimationOutStart();
        sideBar.AnimationOutStart();
        featuredLine.AnimationOutStart();
        playerDetails.AnimationOutStart();
        playerLevelText.AnimationOutStart();
        playerLevelBar.AnimationOutStart();
        friendListPopUp.AnimationOutStart();
        yield return new WaitForSeconds(1f);
    }
}
