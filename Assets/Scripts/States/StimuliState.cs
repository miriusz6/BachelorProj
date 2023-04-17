using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StimuliState : ExperimentState
{
    public CircleArray array;

    public override void Initialize(float duration)
    {
        base.Initialize(duration);
        array.HideStimuli();
    }
    public override void Run()
    {
        base.Run();
        array.ShowStimuli();

    }

    protected override void Update()
    {
        base.Update();
        if (IsFinished()) { array.HideStimuli(); }
    }

}