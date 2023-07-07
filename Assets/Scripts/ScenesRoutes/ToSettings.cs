using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToSettings : MonoBehaviour, IPointerClickHandler
{
    private string settingsScene = "SettingsScene";

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneNavigation.previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(settingsScene);
    }
}
