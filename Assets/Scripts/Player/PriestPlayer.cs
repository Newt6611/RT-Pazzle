using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriestPlayer : Player
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
        Vector3 dir = cursor.GetDirection();
        Cube left = cursor.GetNearCube(Vector3.left);
        Cube right = cursor.GetNearCube(Vector3.right);

        if(left != null)
            left.SetDirection(dir);
        if(right != null)
            right.SetDirection(dir);
    }
}
