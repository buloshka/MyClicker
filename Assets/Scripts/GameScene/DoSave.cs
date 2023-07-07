using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoSave : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private TextMeshProUGUI golds;
    [SerializeField] private TextMeshProUGUI diamonds;
    [SerializeField] private TextMeshProUGUI logs;

    private void Start()
    {
        golds.text = SceneNavigation.golds.ToString();
        diamonds.text = SceneNavigation.diamonds.ToString();
        logs.text = SceneNavigation.woods.ToString();

        SaveData();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SaveData();
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt("Play", SceneNavigation.play ? 1 : 0);
        PlayerPrefs.SetInt("PreviousSceneIndex", SceneNavigation.previousSceneIndex);
        PlayerPrefs.SetInt("Cursor", SceneNavigation.cursor);
        PlayerPrefs.SetInt("Selection", SceneNavigation.selection);
        PlayerPrefs.SetFloat("Volume", SceneNavigation.volume);
        PlayerPrefs.SetFloat("Music", SceneNavigation.music);
        PlayerPrefs.SetInt("Golds", SceneNavigation.golds);
        PlayerPrefs.SetInt("Diamonds", SceneNavigation.diamonds);
        PlayerPrefs.SetInt("Woods", SceneNavigation.woods);
        PlayerPrefs.SetInt("MineWorkers", SceneNavigation.mineWorkers);
        PlayerPrefs.SetInt("MineArea", SceneNavigation.mineArea);
        PlayerPrefs.SetInt("ForestWorkers", SceneNavigation.forestWorkers);
        PlayerPrefs.SetInt("ForestArea", SceneNavigation.forestArea);

        PlayerPrefs.Save();
    }
}
