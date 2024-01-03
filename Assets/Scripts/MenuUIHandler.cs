using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{

    public Text BestScoreText;
    public TMP_InputField nameInput;

    private void Start()
    {
        BestScoreText.text = "Best Score: " + DataManager.instance.bestScoreName + " : " + DataManager.instance.bestScore;
    }
    public void StartOnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        DataManager.instance.SaveNameScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void InputName()
    {
        PlayerPrefs.SetString("currentname", nameInput.text);
    }
}
