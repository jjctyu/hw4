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

        //2 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The factory, after making several navigational decisions, eventually leaves the human settlement and enters an old world city. The buildings that remain standing are decrepit, and the area is littered with old barricades, mines, and cannons. There are bits of plant growth at the edges, but the landscape is predominantly rust and crumbled concrete.";
        temp.text[0] += "Solarite charging opportunity discovered¡­\r\nAnalyzing environment compatibility¡­\r\n¡­\r\nWARNING: Shrapnel storm imminent\r\nSeeking shelter is advised\r\n";


        temp.options = new List<string>();
        temp.options.Add("-Option A | Charge | Enter low power mode to increase Energy, WARNING Hull will suffer structural damage from incoming storm");
        temp.options.Add("-Option B | Shelter | Seek Shelter, WARNING Battery levels approaching  critical");
        events.Add(temp);


        //3 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The factory may fall to disrepair here, or players may be able to survive the derelict war zone and continue on to HOME. Eventually, the buildings and war weapons thin out. \r\n¡°Humans encountered in unexpected area\r\nActivating language processing center¡­\r\n";
        temp.text[0] += "¡­\r\nAnalyzing Input¡­\r\nConclusion: Humans are demanding Solarite Cell Module\r\nAnalyzing compliance¡­\r\nSolarite Cell Module not needed to complete Odyssey Protocol\r\nWARNING Odyssey protocol forbids shedding of any generator components before arriving at destination\r\n";
        temp.text.Add("");
        temp.text[1] += "¡­\r\nAnalyzing human status¡­\r\nArmed : True\r\nHostile: True\r\nDangerous: False\r\nExplanation: Humans are armed with tools insufficient to inflict damage to critical systems¡­ Humans are displaying signs of malnourishment\r\n";


        temp.options = new List<string>();
        temp.options.Add("-Option A | Comply | Relinquish Solar Cell WARNING contradicts Odyssey Protocol");
        temp.options.Add("-Option B | Continue | Continue Odyssey Protocol, superficial damage from Human Arms");
        events.Add(temp);


        //4 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "An old mechanical factory, encountered a group of destitute refugees while carrying out its final mission. On the way, they approached, requesting a ride for a short distance as they were too exhausted and in need of a brief rest. ";
   


        temp.options = new List<string>();
        temp.options.Add("-Option A | Agree give them a ride | Duration decreases , energy decreases.(receive a gift from refuges)");
        temp.options.Add("-Option B | Ignore them and keep moving to the final destination. Nothing happened");
        events.Add(temp);


        //5 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "In the quiet wilderness, a place that should have been devoid of any sound suddenly acquired a rhythmic noise. An antiquated machine continued its operation, but it had no choice but to come to a halt. Up ahead, the remnants left by war obstructed its path. Perhaps, in the past, clearing war debris was a part of its duties. However, now it felt powerless in the face of the wreckage left by the conflict.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Use body To crush the remant  | decrease health");
        temp.options.Add("-Option B | Find another way to the destination | decrease the energy.");
        events.Add(temp);


        //6 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "During the journey, passing by a dilapidated craftsman's hut, the craftsman is preparing to leave this place to seek a living elsewhere. He happens to need some energy to charge his vehicle. He proposes to make a deal with you ¨C if you provide him with some energy, he will do his best to replace your old parts.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | share some energy to him and get fixed.(energy decreased, duration increased)");
        temp.options.Add("-Option B | Ignore the deal, Keep moving(nothing happened)");
        events.Add(temp);

        //7 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The factory meets  Craftsman, he tries to make a deal with you. He needs to find new parts for his vehicle, and you happen to have some. And he will provide you with some energy to help you go further.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Give him the gear he need (duration decreased, Energyincreased)");
        temp.options.Add("-Option B | Ignore the deal, Keep moving(nothing happened)");
        events.Add(temp);


        //8 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The factory arrived at a heavily polluted area, and its program instructed it to clean up the surrounding area. However, cleaning up this area might take some time.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Clean the place (decrease the duration and increase the energy)");
        temp.options.Add("-Option B | Keep Moving Nothing Happened");
        events.Add(temp);


        //9 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The old factory arrived at a severely polluted area, where buildings seemed on the verge of collapsing any second, and an attack might be imminent. However, it had no choice but to stop here, as the terrain ahead was uneven with craters at the bottom of the river, making it highly likely that once it moved forward, it might not return.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Cross the river (decrease the duration)");
        temp.options.Add("-OptionsB | Stay here until the can see the river clearly (decrease the energy)");
        events.Add(temp);

        
        //10 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The old factory's system detected sounds ahead¡ªbandits were attacking refugees. The refugees appeared defenseless, and the bandits seemed unaware of the mobile factory's presence. As a machine created by humans, the Three Laws of Robotics dictated that the machine should protect humans. However, the Odyssey Protocol instructed minimizing mechanical wear and energy consumption.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Help refugees (decrease the duration and energy)");
        temp.options.Add("-Option B | keep processing the Odyssey Protocol");
        events.Add(temp);



        //11 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The mobile factory, dragging its cumbersome frame, moved towards the depths of the ruins. System detection revealed the presence of several Cleaners. They appeared to have moved here together, but unfortunately, their bodies had long been scrapped, and their systems were shut down just before reaching their final destination. However, there was still residual energy in their power sources.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Take their energy (Increase the energy)");
        temp.options.Add("-Option B | May they rest in the peace(Nothing happened)");
        events.Add(temp);


        //12 random
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The mobile factory encountered a settlement of refugees who expressed their desire to accompany it for a portion of the journey to ensure their safety. In return, they offered to provide some energy resources and assist with simple repairs to the factory.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Allow them to follow you ");
        temp.options.Add("-Option B | leave them and keep moving.");
        events.Add(temp);


        //17 
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "As everything was approaching its conclusion, the old factory encountered another severely damaged factory that was also on the brink of its final rest. The two machines locked eyes, as if communicating something profound without words.";



        temp.options = new List<string>();
        temp.options.Add("-Option A | Take it  with you £¨decrease the energy£©");
        temp.options.Add("-Option B | Ignore Him.(decrease energy)");
        events.Add(temp);


        //final 
        temp = new Event();
        temp.text = new List<string>();
        temp.text.Add("");
        temp.text[0] += "The factory travels through a copse of trees, which also eventually thin out to a dusty expanse. As the player continues, the dirt underfoot gives way to grass. Eventually the player runs into a large pile of similar looking factories, all deactivated and in various states of disrepair.\r\n\r\n¡°Destination reached: HOME\r\nOdyssey protocol fulfilled\r\nInitializing Deep Sleep Protocol¡­\r\nScanning for human life¡­\r\n";
        temp.text.Add("");
        temp.text[1] += "¡­\r\nNo Humans detected within scanner range\r\nInitiate Deep Sleep Protocol\r\n¡­\r\nthank you for your service\r\nim sorry we couldnt bury u closer to home \r\nbut here you will not be a danger to people\r\nrest well now \r\n";




        temp.options = new List<string>();
        temp.options.Add("-Option A |Deep Sleep| I¡¯m glad to have helped.");
        events.Add(temp);





    }

    void Start()
    {
        

    }

    


}
