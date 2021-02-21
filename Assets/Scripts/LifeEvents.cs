using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEvents : ChatMenuComponent
{
    public string lifeEvents;
    public ChatMenu lifeEventsChatMenu;

    public LifeEvents(string lifeEvents)
    {
        this.lifeEvents = lifeEvents;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu lifeEventsChatMenu = new ChatMenu(GetNPCResponseText());
        lifeEventsChatMenu.Add(c.childhood);
        lifeEventsChatMenu.Add(c.adolescence);
        lifeEventsChatMenu.Add(c.adulthood);
        lifeEventsChatMenu.Add(c.elder);
        return lifeEventsChatMenu;
    }

    public static LifeEvents ReturnRandomLifeEventsComment()
    {
        List<string> lifeEventsCommentList = new List<string>();
        lifeEventsCommentList.Add("What!? You want to know about my life???");
        lifeEventsCommentList.Add("Oh... I'm not very interesting.");
        lifeEventsCommentList.Add("My parents always warned me about talking to strangers? OK! What do you want to know?");
        lifeEventsCommentList.Add("Are you trying to flirt with me?");
        lifeEventsCommentList.Add("Sure, what would you like to know?");


        LifeEvents lifeEventsComment = new LifeEvents(lifeEventsCommentList[Random.Range(0, lifeEventsCommentList.Count)]);
        return lifeEventsComment;
    }

    public override string GetNPCResponseText()
    {
        return lifeEvents;
    }

    public override string GetButtonText()
    {
        return "Tell me about your life.";
    }
}
