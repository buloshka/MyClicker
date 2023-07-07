using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToBack : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        print(SceneNavigation.previousSceneIndex);
        SceneManager.LoadScene(SceneNavigation.previousSceneIndex);
    }
}
