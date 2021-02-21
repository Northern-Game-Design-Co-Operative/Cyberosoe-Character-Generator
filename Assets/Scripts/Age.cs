using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Age : ChatMenuComponent
{
    public string age;
    public ChatMenu chatMenu;

    public Age(string age)
    {
        this.age = age;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Age ReturnRandomAge()
    {
        Age randomAge = new Age(Random.Range(10, 100).ToString());
        return randomAge;
    }

    public override string GetNPCResponseText()
    {
        return "Looks to be about " + age;
    }

    public override string GetButtonText()
    {
        return "Age";
    }
}
