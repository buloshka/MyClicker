using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TitleColorTransition : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;

    public float colorChangeSpeed = 0.5f;
    private Color[] rainbowColors;

    private int currentIndex = 0;
    private Color currentColor;
    private Color nextColor;

    private void Start()
    {
        rainbowColors = GenerateRainbowColors();
        StartColorTransition();
    }

    private void StartColorTransition()
    {
        StartCoroutine(TransitionColors());
    }

    private System.Collections.IEnumerator TransitionColors()
    {
        while (true)
        {
            currentIndex = (currentIndex + 1) % rainbowColors.Length;
            currentColor = titleText.color;
            nextColor = rainbowColors[currentIndex];

            float time = 0f;
            while (time < 1f)
            {
                time += Time.deltaTime / colorChangeSpeed;
                titleText.color = Color.Lerp(currentColor, nextColor, time);
                yield return null;
            }
        }
    }

    private Color[] GenerateRainbowColors()
    {
        Color[] colors = new Color[7];
        float hueIncrement = 1f / colors.Length;

        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = Color.HSVToRGB(hueIncrement * i, 1f, 1f);
        }

        return colors;
    }
}