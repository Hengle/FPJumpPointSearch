﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TrueSync;
public class FSCharacterController : BaseFSComponent
{
    FP _radius;
    MoveAgent _agent = null;

    public override void OnAwake()
    {
        _agent = new MoveAgent();
    }

    public override void OnStart()
    {
    //    throw new NotImplementedException();
    }

    public override void OnStep()
    {
    //    throw new NotImplementedException();
    }

    public override void OnPostStep()
    {
    //    throw new NotImplementedException();
    }

    public override void OnDestroy()
    {
    //    throw new NotImplementedException();
    }
}
