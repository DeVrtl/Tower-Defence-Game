using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField] private List<Transition> _transitions;

    protected Player Targer { get; set; }

    public void Enter(Player target)
    {
        if (enabled == false)
        {
            Targer = target;
            enabled = true;

            foreach(var transition in _transitions)
            {
                transition.enabled = true;
                transition.Init(Targer);
            }
        }
    }

    public void Exit()
    {
        if (enabled == true)
        {
            foreach (var transition in _transitions)
                transition.enabled = false;

            enabled = false;
        }
    }

    public State GetNextState()
    {
        foreach (var transition in _transitions)
        {
            if (transition.NeedTarnsit)
                return transition.TargetState;
        }

        return null;
    }
}
