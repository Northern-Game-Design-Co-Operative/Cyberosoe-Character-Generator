using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adulthood : ChatMenuComponent
{
    public string adulthood;
    public ChatMenu chatMenu;
    public Adulthood(string adulthood)
    {
        this.adulthood = adulthood;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Adulthood ReturnRandomAdulthoodEvent()
    {
        List<string> adulthoodEventsList = new List<string>();
        adulthoodEventsList.Add("I fell in love.");
        adulthoodEventsList.Add("I became very sick.");
        adulthoodEventsList.Add("I joined the resistance.");
        adulthoodEventsList.Add("I liberated a group of mutant slaves.");
        adulthoodEventsList.Add("I found myself homeless.");
        adulthoodEventsList.Add("I found myself employed by a very generous corporation.");

        Adulthood randomAdulthoodEvent = new Adulthood(adulthoodEventsList[Random.Range(0, adulthoodEventsList.Count)]);

        return randomAdulthoodEvent;
    }

    public override string GetNPCResponseText()
    {
        return "As an adult, " + adulthood;
    }

    public override string GetButtonText()
    {
        return "What was the defining event of your adulthood?";
    }

}
