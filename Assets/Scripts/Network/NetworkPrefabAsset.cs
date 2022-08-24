using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPrefabAsset : NetworkBehaviour, IPlayerLeft
{
    public static NetworkPrefabAsset Local { get; set; }

    private void Start()
    {
        
    }

    public override void Spawned()
    {
        if (Object.HasInputAuthority)
        {
            Local = this;
            Camera.main.gameObject.SetActive(false);
            Debug.Log("spawned local palyer");
        }
        else
        {
            Camera localCamera = GetComponentInChildren<Camera>();
            localCamera.enabled = false;
            AudioListener localAudioListener = GetComponentInChildren<AudioListener>();
            localAudioListener.enabled = false;
            Debug.Log("spawned remote player");
        }
    }

    public void PlayerLeft(PlayerRef player)
    {
        throw new System.NotImplementedException();
    }
}
