using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This file is used to pop up next events based on preset logic: strings pearls or desicion tree


public class EventScheduler : MonoBehaviour
{

    [SerializeField]
    Narrative narrative;

    int size = 0;
    int cur = 0;

    // Start is called before the first frame update
    void Start()
    {

        size = narrative.loadSize();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Dialogue getNextEvent()
    {
        if (cur == size)
        {
            return null;
        }
        Dialogue dialogue = narrative.getEventAtIndex(cur);
        cur += 1;
        return dialogue;
    }

}
