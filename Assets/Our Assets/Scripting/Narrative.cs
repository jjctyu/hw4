using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A Hacky file to store all the dialogues / text of the game. 



public class Narrative : MonoBehaviour
{
    private class Dialogue
    {
        public string text;
        public List<string> options;
    }


    private List<Dialogue> events;

    void Start()
    {
        events = new List<Dialogue>();
        int event_count = 1;



        //adding all the events
        for (int i = 0; i < event_count; i++)
        {
            Dialogue temp = new Dialogue();
            temp.text = "The old machine(Player) wakes up in a small inhabited area; It is a large mobile factory and can see in the UI . With the Text displayed above, the factory starts heading towards the Northern Plains Biome. The player has a scrap, health, and energy stats. Immediately they are running into problems that put a drain on those resources.";
            temp.options = new List<string>();
            temp.options.Add("-Option A| Proceed | potential damage to human crops");
            temp.options.Add("-Option B| Reorient | increases Travel Distance & Energy Usage¡±");
            events.Add(temp);
        }

    }


}
