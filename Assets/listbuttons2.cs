using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro; // Se estiver usando TextMeshPro

public class listbuttons2 : MonoBehaviour
{
    public List<Button> buttons;
    public Color selectedColor = Color.green;
    public Color defaultColor = Color.white;

    private const string prefsKey = "SelectedButtons_";

    void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(() => ToggleButton(index));
        }

        LoadSelections();
    }

    void ToggleButton(int index)
    {
        bool isSelected = PlayerPrefs.GetInt(prefsKey + index, 0) == 1;
        PlayerPrefs.SetInt(prefsKey + index, isSelected ? 0 : 1);
        PlayerPrefs.Save();

        UpdateButtonVisuals(index, !isSelected);
    }

    void LoadSelections()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            bool isSelected = PlayerPrefs.GetInt(prefsKey + i, 0) == 1;
            UpdateButtonVisuals(i, isSelected);
        }
    }

    void UpdateButtonVisuals(int index, bool isSelected)
    {
        Button button = buttons[index];

        // Muda a cor de fundo
        Image image = button.GetComponent<Image>();
        if (image != null)
        {
            image.color = isSelected ? selectedColor : defaultColor;
        }

        // Tenta pegar o componente de texto (Text ou TextMeshProUGUI)
        Text legacyText = button.GetComponentInChildren<Text>();
        if (legacyText != null)
        {
            legacyText.fontStyle = isSelected ? FontStyle.Bold : FontStyle.Normal;
        }

        TMP_Text tmpText = button.GetComponentInChildren<TMP_Text>();
        if (tmpText != null)
        {
            tmpText.fontStyle = isSelected ? FontStyles.Bold : FontStyles.Normal;
        }
    }
}
