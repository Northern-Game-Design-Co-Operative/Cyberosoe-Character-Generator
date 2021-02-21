using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Appearance : ChatMenuComponent
{
    public string appearance;
    public ChatMenu appearanceChatMenu;

    public Appearance(string appearance)
    {
        this.appearance = appearance;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu appearanceChatMenu = new ChatMenu(GetNPCResponseText());
        appearanceChatMenu.Add(c.race);
        appearanceChatMenu.Add(c.gender);
        appearanceChatMenu.Add(c.age);
        appearanceChatMenu.Add(c.stats);

        return appearanceChatMenu;
    }

    public static Appearance ReturnRandomAppearanceComment()
    {
        List<string> appearanceCommentList = new List<string>();
        appearanceCommentList.Add("What are you looking at?");
        appearanceCommentList.Add("Looks like you can't take your eyes off me...");
        appearanceCommentList.Add("Do you have a staring problem?");
        appearanceCommentList.Add("Do you like what you see?");
        appearanceCommentList.Add("Am I good looking or what?");


        Appearance randomAppearanceComment = new Appearance(appearanceCommentList[Random.Range(0, appearanceCommentList.Count)]);
        return randomAppearanceComment;
    }

    public override string GetNPCResponseText()
    {
        return appearance;
    }

    public override string GetButtonText()
    {
        return "Appearance";
    }
}
