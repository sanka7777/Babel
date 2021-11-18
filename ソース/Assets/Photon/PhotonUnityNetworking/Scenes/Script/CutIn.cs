using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CutIn : MonoBehaviourPun
{
    public GameObject panel;
    private bool IsLock=false;
    private void Start()
    {
        panel.SetActive(false);

    }

    private void Update()
    {
        var hashtable = PhotonNetwork.CurrentRoom.CustomProperties;
        if((bool)hashtable["isChanged"]){
            panel.SetActive(true);
            IsLock=true;
            Invoke("Wait",1);
        }
        if(!IsLock){
            panel.gameObject.SetActive(false);
        }
    }

    private void Wait(){
        IsLock=false;
        return;
    }
}
