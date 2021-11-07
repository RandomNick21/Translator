using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "TranslateData")]
public class TranslateData : ScriptableObject
{
    public LanguageData CurrentLanguage;
    public List<Data> Data = new List<Data>();

    private static TranslateData instance;
    public static TranslateData GetData()
    {
        if(instance == null)
            instance = Resources.Load("TranslateData") as TranslateData;

        return instance;
    }
}

[Serializable]
public class Data
{
    public string Russian;
    public string English;
}

public enum LanguageData : byte
{
    Russian,
    English,
}