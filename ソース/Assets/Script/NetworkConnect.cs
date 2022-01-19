using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkConnect : MonoBehaviourPunCallbacks
{
    [SerializeField] private string gameVersion = "0.1";
    [SerializeField] private string nickName = "TestName";
    [SerializeField] private string roomName = "TestRoom";

    private void Awake()
    {
        if(PhotonNetwork.IsConnected)return;
        Connect();
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.NickName = nickName;
    }

    private void Connect()
    {
        if(PhotonNetwork.IsConnected)return;
        Debug.Log("Photon Cloud に接続します。");
        PhotonNetwork.ConnectUsingSettings();
    }
 
    public override void OnConnectedToMaster()
    {
        Debug.Log("Photon Cloud に接続しました。");

    }

    public override void OnJoinedLobby()
    {
       SceneManager.LoadScene("RoomSelect");
    }
  
    //スタートボタンが押されると呼ばれるメソッド
     public void EnterLobby()
    {
       if(PhotonNetwork.IsConnected){
           PhotonNetwork.JoinLobby();
       }
    }
}
