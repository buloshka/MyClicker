using System.Collections;
using TMPro;
using UnityEngine;

public class UpdateCurrent : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI golds;
    [SerializeField] private TextMeshProUGUI logs;

    private void Start()
    {
        StartCoroutine(Current());
        StartCoroutine(UpdateCurrency());
    }

    private IEnumerator Current()
    {
        while (true)
        {
            golds.text = (int.Parse(golds.text) + SceneNavigation.mineWorkers * (1 + SceneNavigation.mineArea)).ToString();
            logs.text = (int.Parse(logs.text) + SceneNavigation.forestWorkers * (1 + SceneNavigation.forestArea)).ToString();

            yield return new WaitForSeconds(1f);
        }
    }

    private IEnumerator UpdateCurrency()
    {
        while (true)
        {
            SceneNavigation.golds = int.Parse(golds.text) + SceneNavigation.mineWorkers * (1 + SceneNavigation.mineArea);
            SceneNavigation.woods = int.Parse(logs.text) + SceneNavigation.forestWorkers * (1 + SceneNavigation.forestArea);

            yield return new WaitForSeconds(0.01f);
        }
    }
}
