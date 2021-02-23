using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public Player player;

    private IGameState current_state;
    public Dictionary<string, IGameState> state_cache { get; private set; }

    private void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        state_cache = new Dictionary<string, IGameState>()
        {
            { "Playing", new PlayingState(this) },
            { "NPC", new NPCState(this) }
        };

        current_state = state_cache["Playing"];
        current_state.OnStart();
    }

    private void Update() 
    {
        current_state.OnUpdate();    
    }

    private void FixedUpdate() 
    {
        current_state.OnFixedUpdate();    
    }

    public void SetState(IGameState _state)
    {
        current_state.OnShutDown();
        current_state = _state;
        current_state.OnStart();
    }
}
