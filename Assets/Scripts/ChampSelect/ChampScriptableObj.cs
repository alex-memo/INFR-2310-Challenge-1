using UnityEngine;
/// <summary>
/// @alex-memo 2023
/// </summary>
[CreateAssetMenu(fileName = "NewChampObj", menuName = "Champs/Champ")]
public class ChampScriptableObj : ScriptableObject
{
    public string ChampName;
    public Sprite ChampSprite;
    public Sprite SplashArt;
    public Sprite CompleteSplashArt;
}
