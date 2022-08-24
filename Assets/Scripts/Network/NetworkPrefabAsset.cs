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
            Debug.Log("spawned local palyer");
        }
        else
        {
            Debug.Log("spawned remote player");
        }
    }

    public void PlayerLeft(PlayerRef player)
    {
        throw new System.NotImplementedException();
    }
}
