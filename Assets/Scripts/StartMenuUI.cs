using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenuUI : MonoBehaviour
{
    [SerializeField] Text PlayerNameInput;
    //public void NameEntry(string name)
    //{
        //Allow String Input into the NameEntryField textbox
        //name = GameObject.Find ("NameEntryField").GetComponent<InputField>().text;
        //print("Saving " + name);

        //MainManager.Instance.label = name;
    //}

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
