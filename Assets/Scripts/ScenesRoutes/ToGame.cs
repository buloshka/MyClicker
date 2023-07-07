using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToGame : MonoBehaviour, IPointerClickHandler
{
    private string settingsScene = "Game";

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneNavigation.previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(settingsScene);
    }
}
