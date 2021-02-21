using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Profession : ChatMenuComponent
{
    public string profession;
    public ChatMenu chatMenu;

    public Profession(string profession)
    {
        this.profession = profession;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Profession ReturnRandomProfession()
    {
        List<string> professionList = new List<string>();
        professionList.Add("cook");
        professionList.Add("soldier");
        professionList.Add("slave");
        professionList.Add("bum");
        professionList.Add("servant");
        professionList.Add("hacker");

        Profession randomProfession = new Profession(professionList[Random.Range(0, professionList.Count)]);
        return randomProfession;
    }

    public override string GetNPCResponseText()
    {
        return "I am a " + profession;
    }

    public override string GetButtonText()
    {
        return "What is your profession";
    }
}
