using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A Hacky file to store all the dialogues / text of the game. 


public class Event
{
    public List<string> text;
    public List<string> options;
    // some stats result in the follow.

}


public class Narrative : MonoBehaviour
{
    
    private List<Event> events;

    public int loadSize()
    {
        return events.Count;
    }

    public Event getEventAtIndex(int index)
    {
        return events[index];
    }

    private void Awake()
    {
        events = new List<Event>();


        //adding all the events

        //1 
        Event temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "Performing System Diagnostics¡­ \r\n Solarium Maximum Charge Capacity¡­ 37%\r\nIntake Charge Efficiency¡­ 6.57%\r\nTime to Full Charge ¡­ CANNOT BE DETERMINED\r\nAnalyzing procedures¡­\r\n¡­\r\nInitialize Odyssey Protocol\r\nDestination set: HOME\r\nPriority Alpha\r\n";
        temp.text[0] += "The old machine(Player) wakes up in a small inhabited area; " +
            "It is a large mobile factory and can see in the UI . With the Text displayed above, the factory starts heading towards the Northern Plains Biome. " +
            "The player has a scrap, health, and energy stats. Immediately they are running into problems that put a drain on those resources.";

        temp.text.Add("");
        temp.text[1] += "Obstacle encountered\r\nAnalyzing¡­\r\nPath blocked by Oryza glaberrima¡­\r\nAnalyzing¡­\r\nRice Crop¡­ tended to by local Humans.";




        temp.options = new List<string>();
        temp.options.Add("-Option A| Proceed | potential damage to human crops");
        temp.options.Add("-Option B| Reorient | increases Travel Distance & Energy Usage");
        events.Add(temp);

        //2
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The factory, after making several navigational decisions, eventually leaves the human settlement and enters an old world city. The buildings that remain standing are decrepit, and the area is littered with old barricades, mines, and cannons. There are bits of plant growth at the edges, but the landscape is predominantly rust and crumbled concrete.";
        temp.text[0] += "Solarite charging opportunity discovered¡­\r\nAnalyzing environment compatibility¡­\r\n¡­\r\nWARNING: Shrapnel storm imminent\r\nSeeking shelter is advised\r\n";


        temp.options = new List<string>();
        temp.options.Add("-Option A | Charge | Enter low power mode to increase Energy, WARNING Hull will suffer structural damage from incoming storm");
        temp.options.Add("-Option B | Shelter | Seek Shelter, WARNING Battery levels approaching  critical");
        events.Add(temp);

    }

    void Start()
    {
        

    }

    


}
