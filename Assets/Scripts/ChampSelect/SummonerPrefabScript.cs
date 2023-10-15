using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class SummonerPrefabScript : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text champName;
    [SerializeField] private Image champSplashArt;
    [SerializeField] private GameObject border;
    private Color imageColor=new(255,255,255,1);
    public void SelectInChamp(ChampScriptableObj _champ)
    {
        champName.text = _champ.ChampName;
        champSplashArt.sprite=_champ.SplashArt;
        champSplashArt.color = imageColor;
        border.SetActive(true);
    }
}
