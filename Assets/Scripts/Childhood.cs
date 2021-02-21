using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Childhood : ChatMenuComponent
{
    public string childhood;
    public ChatMenu chatMenu;
    public Childhood(string childhood)
    {
        this.childhood = childhood;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Childhood ReturnRandomChildhoodEvent()
    {
        List<string> childhoodEventsList = new List<string>();
        childhoodEventsList.Add("I fell in love.");
        childhoodEventsList.Add("I became very sick.");
        childhoodEventsList.Add("I joined the resistance.");
        childhoodEventsList.Add("I liberated a group of mutant slaves.");
        childhoodEventsList.Add("I found myself homeless.");
        childhoodEventsList.Add("I found myself employed by a very generous corporation.");

        Childhood randomChildhoodEvent = new Childhood(childhoodEventsList[Random.Range(0, childhoodEventsList.Count)]);

        return randomChildhoodEvent;
    }

    public override string GetNPCResponseText()
    {
        return "As I a child, " + childhood;
    }

    public override string GetButtonText()
    {
        return "What was the defining event of your childhood?";
    }

}
