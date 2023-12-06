using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A Hacky file to store all the dialogues / text of the game. 


public class Dialogue
{
    public string text;
    public List<string> options;
}


public class Narrative : MonoBehaviour
{
    
    private List<Dialogue> events;

    private void Awake()
    {
        events = new List<Dialogue>();


        //adding all the events

        //1 
        Dialogue temp = new Dialogue();
        temp.text = "The old machine(Player) wakes up in a small inhabited area; It is a large mobile factory and can see in the UI . With the Text displayed above, the factory starts heading towards the Northern Plains Biome. The player has a scrap, health, and energy stats. Immediately they are running into problems that put a drain on those resources.";
        temp.options = new List<string>();
        temp.options.Add("-Option A| Proceed | potential damage to human crops");
        temp.options.Add("-Option B| Reorient | increases Travel Distance & Energy Usage");
        events.Add(temp);
    }

    void Start()
    {
        

    }

    public int loadSize()
    {
        return events.Count;
    }

    public Dialogue getEventAtIndex(int index)
    {
        return events[index];
    }


}
