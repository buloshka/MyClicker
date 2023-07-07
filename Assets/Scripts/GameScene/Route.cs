using UnityEngine;
using UnityEngine.EventSystems;

public class Route : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject mainScreen;
    [SerializeField] private GameObject childScreen1;
    [SerializeField] private GameObject childScreen2;

    public void OnPointerClick(PointerEventData eventData)
    {
        mainScreen.SetActive(true);
        childScreen1.SetActive(false);
        childScreen2.SetActive(false);
    }
}
