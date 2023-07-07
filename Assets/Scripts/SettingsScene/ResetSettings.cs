using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResetSettings : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Slider sounds;
    [SerializeField] private Slider music;

    private void Awake()
    {
        ResetSavedData();
    }

    private void ResetSavedData()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();

        SceneNavigation.play = false;
        SceneNavigation.previousSceneIndex = 0;
        SceneNavigation.cursor = -1;
        SceneNavigation.selection = -1;
        SceneNavigation.volume = 0.7f;
        SceneNavigation.music = 0.5f;
        SceneNavigation.golds = 0;
        SceneNavigation.diamonds = 0;
        SceneNavigation.woods = 0;
        SceneNavigation.mineWorkers = 0;
        SceneNavigation.mineArea = 0;
        SceneNavigation.forestWorkers = 0;
        SceneNavigation.forestArea = 0;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        sounds.value = 0.7f;

        music.value = 0.5f;

        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        SceneNavigation.cursor = -1;
    }
}
