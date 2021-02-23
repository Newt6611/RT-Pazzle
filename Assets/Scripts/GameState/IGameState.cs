﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IGameState : MonoBehaviour
{
    public abstract void OnStart();
    public abstract void OnUpdate();
    public abstract void OnFixedUpdate();
    public abstract void OnShutDown();
}

