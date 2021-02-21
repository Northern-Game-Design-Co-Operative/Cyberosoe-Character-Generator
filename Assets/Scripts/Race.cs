using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : ChatMenuComponent
{
    public string race;
    public ChatMenu raceChatMenu;

    public Race(string race)
    {
        this.race = race;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu raceChatMenu = new ChatMenu(GetNPCResponseText());
        raceChatMenu.Add(c.appearance);
        raceChatMenu.Add(c.profession);
        return raceChatMenu;
    }

    public static Race ReturnRandomRace()
    {
        List<string> raceList = new List<string>();
        raceList.Add("Pure Human");
        raceList.Add("Mutant");
        raceList.Add("Cyborg");

        Race randomRace = new Race(raceList[Random.Range(0, raceList.Count)]);

        return randomRace;

    }

    public override string GetNPCResponseText()
    {
        return "Looks like a " + race;
    }

    public override string GetButtonText()
    {
        return "Examine race";
    }
}
