using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adolescence : ChatMenuComponent
{
    public string adolescence;
    public ChatMenu chatMenu;
    public Adolescence(string adolescence)
    {
        this.adolescence = adolescence;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Adolescence ReturnRandomAdolescenceEvent()
    {
        List<string> adolescenceEventsList = new List<string>();
        adolescenceEventsList.Add("I fell in love.");
        adolescenceEventsList.Add("I became very sick.");
        adolescenceEventsList.Add("I joined the resistance.");
        adolescenceEventsList.Add("I liberated a group of mutant slaves.");
        adolescenceEventsList.Add("I found myself homeless.");
        adolescenceEventsList.Add("I found myself employed by a very generous corporation.");

        Adolescence randomAdolescenceEvent = new Adolescence(adolescenceEventsList[Random.Range(0, adolescenceEventsList.Count)]);

        return randomAdolescenceEvent;
    }

    public override string GetNPCResponseText()
    {
        return "As an adolescent, " + adolescence;
    }

    public override string GetButtonText()
    {
        return "What was the defining event of your adolescence?";
    }

}
