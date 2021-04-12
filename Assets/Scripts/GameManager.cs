using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager m_Instance;
    public static GameManager Instance { get { return m_Instance; } }

    [HideInInspector] public Player player;


    // UI Stuff
    // Testing
    public GameObject Dialogue;


    private IGameState current_state;
    public Dictionary<string, IGameState> state_cache { get; private set; }

    [SerializeField] private Animator animator;

    private void Awake()
    {
        if(m_Instance != null && !m_Instance != this)
            Destroy(this.gameObject);
        else
            m_Instance = this;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
        state_cache = new Dictionary<string, IGameState>()
        {
            { "Playing", new PlayingState(this) },
            { "NPC", new NPCState(this) },
            { "DIA", new DialogueState(this) }
        };
        current_state = state_cache["Playing"];
    }

    private void Start() 
    {
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

    public void ShowDialogue()
    {
        Dialogue.SetActive(true);
        //animator.SetBool("is_dia", true);
        animator.Play("ShowDialogue");
    }
}
