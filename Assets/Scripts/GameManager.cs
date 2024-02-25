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

public enum PhrasesTaylorSwiftEra
{
    phrase1 = 1,
    phrase2 = 2,
    phrase3 = 3
}



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TaylorSwiftEra selectedEra;
    public PhrasesTaylorSwiftEra selectedPhrase;

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