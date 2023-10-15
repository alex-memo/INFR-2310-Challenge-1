using System.Collections;
using UnityEngine;
/// <summary>
/// @alex-memo 2023
/// </summary>
public static class Extensions
{
    /// <summary>
    /// Interpolates from initialPosition to end position using Lerp with ease-in, ease-out.
    /// </summary>
    /// <returns></returns>
    public static IEnumerator AnimateIn(this Transform _transform, Vector3 _initialPos,Vector3 _endPos, float _duration=1)
    {
        float progress = 0f; 

        while (progress < 1f)
        {
            float easedProgress = progress * progress * (3f - 2f * progress);  // Ease-in, ease-out (quadratic formula)

            _transform.localPosition = Vector2.Lerp(_initialPos, _endPos, easedProgress);

            progress += Time.deltaTime / _duration;

            yield return null;
        }

        _transform.localPosition = _endPos;  
    }
    /// <summary>
    /// @memo 2023
    /// Fades away a canvas group
    /// </summary>
    /// <param name="_canvas"></param>
    /// <returns></returns>
    public static IEnumerator FadeAway(this CanvasGroup _canvas)
    {
        if (_canvas != null)
        {
            _canvas.alpha = 1;
            while (_canvas.alpha > .01)
            {
                _canvas.alpha -= Time.deltaTime;
                yield return null;
            }
            _canvas.alpha = 0;
            _canvas.gameObject.SetActive(false);
        }
    }
    /// <summary>
    /// @memo 2023
    /// Fades in a canvas group
    /// </summary>
    /// <param name="_canvas"></param>
    /// <returns></returns>
    public static IEnumerator FadeIn(this CanvasGroup _canvas)
    {
        if (_canvas != null)
        {
            _canvas.gameObject.SetActive(true);
            _canvas.alpha = 0;
            while (_canvas.alpha < .99)
            {
                _canvas.alpha += Time.deltaTime;
                yield return null;
            }
            _canvas.alpha = 1;
        }
    }
}


