using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parents : ChatMenuComponent
{
    public string parents;
    public ChatMenu parentsChatMenu;

    public Parents(string parents)
    {
        this.parents = parents;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu parentsChatMenu = new ChatMenu(GetNPCResponseText());
        parentsChatMenu.Add(c.mother);
        parentsChatMenu.Add(c.father);
        /**
         * We need to create a null ChatMenuComponent...
         */
        parentsChatMenu.Add(c.nullChatMenuComponent);
        parentsChatMenu.Add(c.nullChatMenuComponent);
        return parentsChatMenu;
    }

    public static Parents ReturnRandomParentsComment()
    {
        List<string> parentsCommentList = new List<string>();
        parentsCommentList.Add("Hahaha... You want to know about my Mom and Dad? Well, ok...");
        parentsCommentList.Add("You are asking me about my parents? That's so strange...");
        parentsCommentList.Add("Sure, we can talk about my parents...");
        parentsCommentList.Add("What about them!?!");

        Parents randomParentsComment = new Parents(parentsCommentList[Random.Range(0, parentsCommentList.Count)]);
        return randomParentsComment;
    }

    public override string GetNPCResponseText()
    {
        return parents;
    }

    public override string GetButtonText()
    {
        return "What about your parents?";
    }
}