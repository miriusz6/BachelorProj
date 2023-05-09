using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentSetting {
    public int numbOfTargets { private set; get; }
    public int numbOfDistractors { private set; get; }
    public int depth { private set; get; }
    public bool targetsFarAway { private set; get; }
    public bool distractorsFarAway { private set; get; }
    public List<float> timeIntervals { private set; get; } = new List<float>() { 2.0f, 5.0f, 10.0f };

    public ExperimentSetting(int NumbOftargets, int NumbOfdistractors, bool targetsFarAway, bool distractorsFarAway, int Depth, List<float> TimeIntervals) {
        this.numbOfTargets = NumbOftargets;
        this.numbOfDistractors = NumbOfdistractors;
        this.targetsFarAway = targetsFarAway;
        this.distractorsFarAway = distractorsFarAway;
        this.depth = Depth;
        this.timeIntervals = TimeIntervals;
    }

    public ExperimentSetting(int NumbOftargets, int NumbOfdistractors, bool targetsFarAway, bool distractorsFarAway, int Depth) {
        this.numbOfTargets = NumbOftargets;
        this.numbOfDistractors = NumbOfdistractors;
        this.targetsFarAway = targetsFarAway;
        this.distractorsFarAway = distractorsFarAway;
        this.depth = Depth;
    }
}