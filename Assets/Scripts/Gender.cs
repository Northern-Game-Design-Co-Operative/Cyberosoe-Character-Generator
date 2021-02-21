using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gender : ChatMenuComponent
{
    public string gender;
    public ChatMenu chatMenu;

    public Gender(string gender)
    {
        this.gender = gender;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = new ChatMenu(GetNPCResponseText());
        chatMenu.Add(c.appearance);
        chatMenu.Add(c.profession);
        return chatMenu;
    }


    public static Gender ReturnRandomGender()
    {
        List<string> genderList = new List<string>();
        genderList.Add("male");
        genderList.Add("female");

        Gender randomGender = new Gender(genderList[Random.Range(0, genderList.Count)]);

        return randomGender;
    }

    public override string GetNPCResponseText()
    {
        return "Looks like a " + gender;
    }

    public override string GetButtonText()
    {
        return "Examine gender";
    }
}
