using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI)), ExecuteAlways]
public class TranslateTextComponent : MonoBehaviour
{
    [Tooltip("Соответствует нужному элементу листа SO TranslateData")]
    [SerializeField] private int ID;
    private TranslateData DataSO;
    private TextMeshProUGUI Text;

    private void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();

        DataSO = TranslateData.GetData();

        Translate();
    }
#if(UNITY_EDITOR)
    private void Update()
    {
        Translate();
    }
#endif
    private void Translate()
    {
        try
        {
            GetDataTranslations();
        }
        catch
        {
            Text.text = "Not translated";
        }
    }
    private void GetDataTranslations()
    {
        string str;
        if (DataSO.CurrentLanguage == LanguageData.Russian)
        {
            str = DataSO.Data[ID].Russian;
        }
        else
        {
            str = DataSO.Data[ID].English;
        }

        if (str != "")
        {
            Text.text = str;
        }
        else
        {
            Text.text = "Empty";
        }
    }
}
