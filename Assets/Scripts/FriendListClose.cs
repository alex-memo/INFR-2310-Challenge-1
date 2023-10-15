using UnityEngine;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class FriendListClose : MonoBehaviour
{
    [SerializeField] private InterpolatedComponent friendListPopUp;
    private Transform listHideIcon;
    private bool isHidden;
    private RectTransform rect;
    public void PressButton()
    {
        Vector3 _newRot = new();
        if (isHidden)
        {
            friendListPopUp.AnimationInStart();
        }
        else
        {
            friendListPopUp.AnimationOutStart();
        }
        isHidden = !isHidden;
        _newRot.z = isHidden ? -90 : 90;
        transform.eulerAngles = _newRot;
        //rect.rotation = _newRot;
    }
    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

}
