using System.Collections;
using UnityEngine;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class InterpolatedComponent : MonoBehaviour
{

    [SerializeField] private Vector3 locationDisplacement;
    private bool isAnimating;
    private Vector3 endPos;
    private Vector3 initialPos;
    public void AnimationInStart()
    {
        if (isAnimating) { return; }
        StartCoroutine(animateIn());
    }
    public void AnimationOutStart()
    {
        if (isAnimating) { return; }
        StartCoroutine(animateOut());
    }
    /// <summary>
    /// Waits for animation to finish to set isAnimating to false.
    /// </summary>
    /// <returns></returns>
    private IEnumerator animateIn()
    {
        isAnimating = true;
        yield return transform.AnimateIn(initialPos, endPos);
        isAnimating = false;
    }
    private IEnumerator animateOut()
    {
        isAnimating = true;
        yield return transform.AnimateIn(endPos, initialPos);
        isAnimating = false;
    }
    private void Awake()
    {
        initialPos = transform.localPosition;
        endPos = transform.localPosition;
        initialPos += locationDisplacement;
        transform.localPosition = initialPos;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        var _rect=GetComponent<RectTransform>().rect;
        Vector3 _size = new(_rect.width, _rect.height);
        Gizmos.DrawWireCube(transform.position+locationDisplacement*2, _size*2);
    }
}
