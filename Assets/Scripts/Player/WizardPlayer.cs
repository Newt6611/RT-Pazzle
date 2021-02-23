using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardPlayer : Player
{
    [SerializeField] private GameObject smoke_explore_effect;

    [SerializeField] private float skill_cool_down;
    private bool can_skill = true;

    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
    }

    public override void OnFixedUpdate()
    {
        base.OnFixedUpdate();
    }

    public override void OnShutDown()
    {
        base.OnShutDown();
    }


    // Wizard's Skill
    public override void OnTriggerSkill()
    {
        if(current_cube && can_skill)
        {
            // Spawn Particle Effect
            GameObject part_1 = Instantiate(smoke_explore_effect, transform.position, Quaternion.identity);
            
            can_skill = false;
            StartCoroutine(Delay());

            ///////////////////////////////////////////////////////////////////////////////////////
            // Check if next cube or next next cube is empty, then translate player to empty cube
            Cube nextCube = current_cube.GetNextCube(direction);
            Cube nextnextCube = current_cube.GetNextCube(direction).GetNextCube(direction);
            
            if(nextCube.CompareTag("EmptyCube"))
                transform.position =  nextCube.player_position.position;
            else if(nextnextCube.CompareTag("EmptyCube"))
                transform.position =  nextCube.player_position.position;
            else
                transform.position = current_cube.GetNextCube(direction).GetNextCube(direction).player_position.position;
            ///////////////////////////////////////////////////////////////////////////////////////

            // Spawn Particle Effect
            GameObject part_2 = Instantiate(smoke_explore_effect, transform.position, Quaternion.identity);

            Destroy(part_1, 1.5f);
            Destroy(part_2, 1.5f);

            target_position = null;
            current_cube.RemovePlayer(this);
            GetNewCurrentCube();
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(skill_cool_down);
        can_skill = true;
    }
}
