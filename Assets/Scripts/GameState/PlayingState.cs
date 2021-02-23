using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingState : IGameState
{
    private GameManager game_manager;

    public PlayingState(GameManager _manager)
    {
        this.game_manager = _manager;
    }

    public override void OnStart()
    {
        game_manager.player.OnStart();
    }

    public override void OnUpdate()
    {
        game_manager.player.OnUpdate();

        if(game_manager.player.NPC())
            game_manager.SetState(game_manager.state_cache["NPC"]);
    }

    public override void OnFixedUpdate()
    {
        game_manager.player.OnFixedUpdate();
    }

    public override void OnShutDown()
    {
        game_manager.player.OnShutDown();
        Debug.Log("Playing State Shutdonw");
    }
}
