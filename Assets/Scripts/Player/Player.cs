using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

enum player
{
    playerOne, playerTwo
}

// Todo:
//      Implement Get Sutned

public class Player : MonoBehaviour
{
    protected PlayerInput inputs;

    protected Cube current_cube;
    public Cube Current_Cube { get { return current_cube; } }

    [SerializeField] private LayerMask cube_mask;
    [SerializeField] protected Cursor cursor;

    [HideInInspector] public Transform target_position;
    protected Vector3 direction;
    [SerializeField] protected float player_speed;
    private float player_move_speed = 40;
    

    private bool can_press;
    private float press_delay = 1.0f;
    private float press_delay_btw = 0.0f;

    public virtual void OnStart()
    {
        GetNewCurrentCube();
        cursor.InitCursor(this);
        
        // Init input system
        inputs = GetComponent<PlayerInput>();
    }

    public virtual void OnUpdate() 
    {
        DelayCursorEnter();
    }

    public virtual void OnFixedUpdate()
    {
        Movement();
    }

    public virtual void OnShutDown() { }


    // Player States
    public void Stuned()
    {
        // By Sword Man's Skill
    }




    private void Movement()
    {
        if(target_position != null && Vector3.Distance(transform.position, target_position.position) < 0.05f)
        {
            target_position = null;
            GetNewCurrentCube();
        }

        if(target_position != null) 
        {
            transform.position = Vector3.MoveTowards(transform.position, target_position.position, player_move_speed * Time.fixedDeltaTime);
        }
    }

    public void GetNewCurrentCube()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, cube_mask)) 
        {
            Cube c = hit.transform.GetComponent<Cube>();
            if(c.CompareTag("EmptyCube"))
            {
                c.SetPlayer(this);
                return;
            }
            
            current_cube = c;
            current_cube.SetPlayer(this);

            // if touch turn cube then record the direction
            // if touch normal cube then move character to next cube with previous direction
            if(current_cube.transform.CompareTag("TurnCube"))
                direction = current_cube.GetComponent<TurnCube>().GetDirection();
            else if(current_cube.transform.CompareTag("Cube"))
                StartCoroutine(DelayToNextCube(0.7f));
        }
    }

    

    private IEnumerator DelayToNextCube(float time)
    {
        yield return new WaitForSeconds(time);
        target_position = current_cube.GetNextCubePlayerPos(direction);
    }  

    protected void DelayCursorEnter()
    {
        if(!can_press)
        {
            if(press_delay_btw >= 0)
            {
                press_delay_btw -= Time.deltaTime;
            }
            else
            {
                can_press = true;
                press_delay_btw = press_delay;
            }
        }
    }



    // Input Action Call Backs
    public void SetCursorMovement(InputAction.CallbackContext value) 
    {
        cursor.SetMovement(value.ReadValue<Vector2>());
    }

    public void OnTriggerCursor()
    {
        if(can_press)
        {
            can_press = false;

            // Trigger Cursor And Get New Direction
            cursor.OnTriggerCursor();
            if(cursor.ShouldGetNewDir)
                direction = cursor.GetNewDirection();
        }
    }

    public virtual void OnTriggerSkill() {}

    public void OnControlsChange()
    {
        Debug.Log("Controller Changed");
    }



    // Getter
    public float GetSpeed() 
    {
        return player_speed;
    }

    public bool NPC()
    {
        return current_cube.transform.CompareTag("NPC");
    }
}
