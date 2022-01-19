using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
public class FromRoomToSelect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //RoomSelectシーンで退室時に呼ばれる
    public void MoveRoomSelect(){
        PhotonNetwork.LeaveRoom();
        Debug.Log(PhotonNetwork.NetworkClientState);  
    }
    public override void  OnConnectedToMaster() {
         PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        SceneManager.LoadScene("RoomSelect");
    }


}
