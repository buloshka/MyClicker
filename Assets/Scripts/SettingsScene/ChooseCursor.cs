using UnityEngine;
using UnityEngine.EventSystems;

public class ChooseCursor : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Texture2D customCursor;

    public void OnPointerClick(PointerEventData eventData)
    {
        Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.Auto);

        SceneNavigation.cursor = gameObject.transform.parent.GetSiblingIndex();
    }
}
