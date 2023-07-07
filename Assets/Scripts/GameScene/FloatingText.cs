using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class FloatingText : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private TMP_FontAsset fontAsset;
    [SerializeField] private TextMeshProUGUI count;
    [SerializeField] private int text;
    private float floatingHeight = 15f;
    private float floatingDuration = 1f;
    private float fadeDuration = 1f;
    private List<GameObject> textObjects = new List<GameObject>();

    public void OnPointerClick(PointerEventData eventData)
    {
        Vector2 localPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.GetComponent<RectTransform>(), Input.mousePosition, null, out localPosition);

        GameObject textObj = new GameObject("TextPointer");
        textObj.transform.SetParent(canvas.transform);
        textObj.transform.localPosition = localPosition;

        count.text = (int.Parse(count.text) + text).ToString();

        TextMeshProUGUI textMeshPro = textObj.AddComponent<TextMeshProUGUI>();

        RectTransform rectTransform = textObj.GetComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        rectTransform.sizeDelta = Vector2.zero;

        textMeshPro.text = $"+{text}";
        textMeshPro.alignment = TextAlignmentOptions.Center;
        textMeshPro.font = fontAsset;
        textMeshPro.enableWordWrapping = false;

        textObjects.Add(textObj);

        StartCoroutine(FloatingAnimation(textObj));
    }

    private IEnumerator FloatingAnimation(GameObject textObj)
    {
        Vector3 startPosition = textObj.transform.position;
        Vector3 targetPosition = startPosition + new Vector3(0f, floatingHeight, 0f);

        float timer = 0f;

        while (timer < floatingDuration)
        {
            float t = timer / floatingDuration;
            textObj.transform.position = Vector3.Lerp(startPosition, targetPosition, t);

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();

            if (!textObj.activeSelf)
                yield break;
        }

        timer = 0f;

        while (timer < fadeDuration)
        {
            float t = timer / fadeDuration;
            Color textColor = textObj.GetComponent<TextMeshProUGUI>().color;
            textColor.a = Mathf.Lerp(1f, 0f, t);
            textObj.GetComponent<TextMeshProUGUI>().color = textColor;

            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();

            if (!textObj.activeSelf)
                yield break;
        }

        textObjects.Remove(textObj);
        Destroy(textObj);
    }

    private void OnDisable()
    {
        StopAllCoroutines();

        foreach (GameObject textObj in textObjects)
        {
            Destroy(textObj);
        }

        textObjects.Clear();
    }
}
