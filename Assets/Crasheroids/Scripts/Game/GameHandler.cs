using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] Player playerPrefab;

    public Player GetPlayer()
    {
        return Instantiate<Player>(playerPrefab);
    }
}
