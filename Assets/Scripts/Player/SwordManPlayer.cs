using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordManPlayer : Player
{
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

    public override void OnTriggerSkill()
    {
        current_cube.GetNextCube(Vector3.forward).StunPlayer();
        current_cube.GetNextCube(Vector3.back).StunPlayer();
        current_cube.GetNextCube(Vector3.right).StunPlayer();
        current_cube.GetNextCube(Vector3.left).StunPlayer();
    }
}
