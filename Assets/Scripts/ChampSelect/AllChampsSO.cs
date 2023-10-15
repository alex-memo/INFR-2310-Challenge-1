using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// @alex-memo 2023
/// </summary>
[CreateAssetMenu(fileName = "NewChampList", menuName = "Champs/List")]
public class AllChampsSO : ScriptableObject
{
    public List<ChampScriptableObj> AllChamps;
}
