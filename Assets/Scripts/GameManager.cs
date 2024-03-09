using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TaylorSwiftEra
{
    TaylorSwift,
    Fearless,
    SpeakNow,
    Red,
    NinteenEightyNine,
    Reputation,
    Lover,
    Folklore,
    Evermore,
    Midnights
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TaylorSwiftEra selectedEra;
    public string selectedPhrase;

    public Dictionary<TaylorSwiftEra, List<string>> eraPhrases = new Dictionary<TaylorSwiftEra, List<string>>()
    {
        { TaylorSwiftEra.TaylorSwift, new List<string>{ "TS", "our song", "tim mcgraw" } },
        { TaylorSwiftEra.Fearless, new List<string>{ "fearless", "love story", "fifteen" } },
        { TaylorSwiftEra.SpeakNow, new List<string>{ "mine", "long live", "enchanted" } },
        { TaylorSwiftEra.Red, new List<string>{ "red", "22", "ATW" } },
        { TaylorSwiftEra.NinteenEightyNine, new List<string>{ "style", "blank space", "this love" } },
        { TaylorSwiftEra.Reputation, new List<string>{ "dress", "gorgeous", "LWYMMD" } },
        { TaylorSwiftEra.Lover, new List<string>{ "lover", "ME", "the man" } },
        { TaylorSwiftEra.Folklore, new List<string>{ "august", "cardigan", "mirrorball" } },
        { TaylorSwiftEra.Evermore, new List<string>{ "gold rush", "Marjorie", "willow" } },
        { TaylorSwiftEra.Midnights, new List<string>{ "karma", "anti hero", "mastermind" } }
    };

    public List<string> GetPhrasesForSelectedEra()
    {
        if (eraPhrases.TryGetValue(selectedEra, out List<string> phrases))
        {
            return phrases;
        }
        else
        {
            Debug.LogError("Selected era has no phrases!");
            return new List<string>();
        }
    }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}