using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldAge : ChatMenuComponent
{
    public string oldage;
    public ChatMenu chatMenu;
    public OldAge(string oldage)
    {
        this.oldage = oldage;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static OldAge ReturnRandomElderlyEvent()
    {
        List<string> oldageEventsList = new List<string>();
        oldageEventsList.Add("I fell in love.");
        oldageEventsList.Add("I became very sick.");
        oldageEventsList.Add("I joined the resistance.");
        oldageEventsList.Add("I liberated a group of mutant slaves.");
        oldageEventsList.Add("I found myself homeless.");
        oldageEventsList.Add("I found myself employed by a very generous corporation.");

        OldAge randomOldAgeEvent = new OldAge(oldageEventsList[Random.Range(0, oldageEventsList.Count)]);

        return randomOldAgeEvent;
    }

    public override string GetNPCResponseText()
    {
        return "As an elder, " + oldage;
    }

    public override string GetButtonText()
    {
        return "What was the defining event of your elder years?";
    }

}
