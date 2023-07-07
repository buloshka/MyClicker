using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChooseSelection : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Transform customSprite;

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneNavigation.selection = customSprite.parent.GetSiblingIndex();
    }
}
