using System;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// @alex-memo 2023
/// </summary>
public class CharacterSelectManager : MonoBehaviour
{
    [SerializeField] private AllChampsSO allChamps;
    [SerializeField] private Transform champsHolder;
    [SerializeField] private GameObject champPrefab;

    [SerializeField] private SummonerPrefabScript playerSummoner;


    [SerializeField] private InterpolatedComponent champsInterpolate;
    [SerializeField] private InterpolatedComponent teamAInterpolate;
    [SerializeField] private InterpolatedComponent teamBInterpolate;

    [SerializeField] private InterpolatedComponent selectedChamp;
    [SerializeField] private Image selectedChampImage;

    [SerializeField] private CanvasGroup lockInButton;

    public static CharacterSelectManager Instance;

    private ChampScriptableObj champ;

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
        foreach (var _champ in allChamps.AllChamps)
        {
            var champObj = Instantiate(champPrefab, champsHolder);
            champObj.GetComponent<CharacterSelectChampPrefabs>().SetChamp(_champ);
        }
    }

    public void SelectChamp(ChampScriptableObj _champ)
    {
        playerSummoner.SelectInChamp(_champ);
        champ = _champ;
        StartCoroutine(lockInButton.FadeIn());
    }
    public void LockIn()
    {
        champsInterpolate.AnimationOutStart();
        setSelectedChamp();
        //reset timer
    }
    public void AnimateAllIn()
    {
        champsInterpolate.AnimationInStart();
    }
    private void setSelectedChamp()
    {
        selectedChampImage.sprite = champ.CompleteSplashArt;
        selectedChamp.AnimationInStart();
    }
}
