using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button)), ExecuteAlways]
public class ButtonTranslate : MonoBehaviour
{
    [SerializeField] private LanguageData LanguageButton; 
    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(EditCurrentLanuage);
    }

    private void EditCurrentLanuage()
    {
        TranslateData.GetData().CurrentLanguage = LanguageButton;
    }
}
