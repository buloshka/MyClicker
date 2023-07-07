using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class MineWorkers : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI current;
    [SerializeField] private int price;
    [SerializeField] private int count;

    public void OnPointerClick(PointerEventData eventData)
    {
        int currentCount = int.Parse(current.text);

        if (currentCount < price)
        {
            return;
        }

        int newCount = currentCount - price;
        current.text = newCount.ToString();

        UpdateCurrency();
    }

    private void UpdateCurrency()
    {
        SceneNavigation.golds = int.Parse(current.text);
        SceneNavigation.mineWorkers += count;
    }
}
