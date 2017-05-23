using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Event> events = new Dictionary<int, Event>();
        
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }
                string[] tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                int id = 0; // ID
                bool isItId = int.TryParse(tokens[0], out id);
                string eventName = tokens[1];
                bool isValidEvent = eventName[0] == '#';

                bool isValidParticipant = true;

               
                if (isItId  && isValidEvent )
                {
                    Event currentEvent = new Event();
                    currentEvent.Participants = new List<string>();
                    currentEvent.Name = eventName;

                    if (!events.Keys.Contains(id))
                    {
                        events[id] = currentEvent;

                    }

                    if (events[id].Name != eventName)
                    {
                        continue;
                    }

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        if (!events[id].Participants.Contains(tokens[i]) && tokens[i][0] == '@')
                        {
                            events[id].Participants.Add(tokens[i]);
                        }
                    }

                }
               
            }
            events = events.OrderByDescending(p => p.Value.Participants.Count).ToDictionary(p => p.Key, x => x.Value);

            foreach (var currentEvent in events)
            {
                Console.WriteLine($"{currentEvent.Value.Name.Remove(0,1)} - {currentEvent.Value.Participants.Count}");

                foreach (var participant in currentEvent.Value.Participants.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
