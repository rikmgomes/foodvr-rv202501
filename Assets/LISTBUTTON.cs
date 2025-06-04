using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class LISTBUTTON : MonoBehaviour
{
    public List<Button> buttons;

    // Cor base (vermelho R255 G15 B0)
    private Color baseColor = new Color(1f, 15f / 255f, 0f, 1f);
    private float visibleAlpha = 120f / 255f;
    private float invisibleAlpha = 0f;

    void Start()
    {
        foreach (Button btn in buttons)
        {
            btn.onClick.AddListener(() => OnButtonClicked(btn));
        }

        UpdateButtonVisuals(null); // Todos começam invisíveis
    }

    void OnButtonClicked(Button clickedButton)
    {
        UpdateButtonVisuals(clickedButton);
    }

    void UpdateButtonVisuals(Button activeButton)
    {
        foreach (Button btn in buttons)
        {
            Image img = btn.GetComponent<Image>();

            if (img != null)
            {
                Color color = baseColor;
                color.a = (btn == activeButton) ? visibleAlpha : invisibleAlpha;
                img.color = color;
            }
        }
    }
}
