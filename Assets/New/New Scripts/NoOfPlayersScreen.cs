using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoOfPlayersScreen : MonoBehaviour
{
    public Button backBtn;
    public Button closeBtn;

    public Button twoPlayerBtn;
    public Button threePlayerBtn;
    public Button fourPlayerBtn;


    void Start()
    {
        backBtn.onClick.AddListener(() => UI_Manager.instance.ChangeScreen(UI_Manager.instance.noOfPlayers.gameObject, false));

    
       twoPlayerBtn.onClick.AddListener(() =>StartGame(2));
       threePlayerBtn.onClick.AddListener(() =>StartGame(3));
       fourPlayerBtn.onClick.AddListener(() =>StartGame(4));


    }
    void StartGame(int i)
    {
        GameRulesManager.noOfPlayers = i;
        SceneManager.LoadScene(Global.GameScene);

        //  StartCoroutine(UI_ScreenManager._ChangeScreen(UI_ScreenManager.instance.uiScene_LoadingScreen.gameObject, gameObject, true));

    }
}
