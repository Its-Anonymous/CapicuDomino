using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinRoomScreen : MonoBehaviour
{
    public Button backBtn;
    public Button joinBtn;
    public InputField roomID;

    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(() => BackBtnCallBack());
        joinBtn.onClick.AddListener(() => JoinBtnCallBack());

    }

    private void OnEnable()
    {
        roomID.text = "";
    }

    public void JoinBtnCallBack()
    {
        if (string.IsNullOrEmpty(roomID.text.Trim()))
        {
            MesgBar.instance.show("Please Enter Room Id",true);
        }
        else 
        {
            GameRulesManager.isPrivateRoom = true;
            GameRulesManager.privateRoomId = roomID.text.Trim();
            //UI_Manager.instance.ChangeScreen(UI_Manager.instance.createJoinRoomButtonPanel.gameObject, false);
            
            UI_Manager.instance.ChangeScreen(UI_Manager.instance.joinRoomScreen.gameObject, false);
            UI_Manager.instance.ChangeScreen(UI_Manager.instance.gameModeScreen.gameObject, true);
        }
    }

    public void BackBtnCallBack()
    {
        UI_Manager.instance.ChangeScreen(UI_Manager.instance.joinRoomScreen.gameObject, false);
    }

}
