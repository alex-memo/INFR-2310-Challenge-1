using System.Collections;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class FeaturedSkinsScript : MonoBehaviour
{
    private InterpolatedComponent[] featuredSkins;
    private void Start()
    {
        featuredSkins=GetComponentsInChildren<InterpolatedComponent>();
        StartCoroutine(animateChild());
    }
    private IEnumerator animateChild()
    {
        foreach (var child in featuredSkins)
        {
            child.AnimationInStart();
            yield return new WaitForSeconds(.3f);
        }
        //transform.GetComponent<GridLayoutGroup>().enabled = true;
    }

}
