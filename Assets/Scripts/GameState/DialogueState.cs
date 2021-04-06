using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueState : IGameState
{
    private GameManager game_manager;

    public DialogueState(GameManager _manager)
    {
        this.game_manager = _manager;
    }

    public override void OnStart()
    {
        Debug.Log("Dialogue State Begin");
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
