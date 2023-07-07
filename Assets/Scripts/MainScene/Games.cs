using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Games : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI play;
    void Start()
    {
        play.text = SceneNavigation.play ? "Play" : "Continue";
    }
}
