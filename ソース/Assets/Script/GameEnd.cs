using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
public class GameEnd : MonoBehaviourPunCallbacks
{
    //ゲーム終了ボタンが押されると呼ばれる
   private void Update() {
      
   }
   public void END(){
       Time.timeScale=1;
       PhotonNetwork.Disconnect();
       Debug.Log(PhotonNetwork.NetworkClientState);  
   }
   public override void OnLeftRoom(){
       SceneManager.LoadScene("Title");
   }
}
