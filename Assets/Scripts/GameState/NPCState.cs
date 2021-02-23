using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : IGameState
{
    private GameManager game_manager;

    public NPCState(GameManager _manager)
    {
        this.game_manager = _manager;
    }

    public override void OnStart()
    {
        Debug.Log("NPCState Start");
    }

    public override void OnUpdate()
    {

    }

    public override void OnFixedUpdate()
    {

    }

    public override void OnShutDown()
    {
        
    }
}
