using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class CharacterSelectChampPrefabs : MonoBehaviour
{
    [SerializeField] private Image champImage;
    private ChampScriptableObj champ;

    public void SetChamp(ChampScriptableObj _champ)
    {
        champImage.sprite = _champ.ChampSprite;
        champ = _champ;
    }
    public void SelectChamp()
    {
        CharacterSelectManager.Instance.SelectChamp(champ);
    }
}
