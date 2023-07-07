using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("SaveExists"))
        {
            LoadSavedData();
        }
        else
        {
            InitializeDefaultData();
        }
    }

    private void LoadSavedData()
    {
        SceneNavigation.play = true;
        SceneNavigation.volume = PlayerPrefs.GetFloat("Volume");
        SceneNavigation.music = PlayerPrefs.GetFloat("Music");
        SceneNavigation.golds = PlayerPrefs.GetInt("Golds");
        SceneNavigation.diamonds = PlayerPrefs.GetInt("Diamonds");
        SceneNavigation.woods = PlayerPrefs.GetInt("Woods");
        SceneNavigation.mineWorkers = PlayerPrefs.GetInt("MineWorkers");
        SceneNavigation.mineArea = PlayerPrefs.GetInt("MineArea");
        SceneNavigation.forestWorkers = PlayerPrefs.GetInt("ForestWorkers");
        SceneNavigation.forestArea = PlayerPrefs.GetInt("ForestArea");
    }

    private void InitializeDefaultData()
    {
        SceneNavigation.play = false;
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
}
