using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatMenu : ChatMenuComponent
{
    List<ChatMenuComponent> chatMenuList = new List<ChatMenuComponent>();
    string NPCMenuInitResponse;

    public ChatMenu(string npcMenuInitResponse)
    {
        this.NPCMenuInitResponse = npcMenuInitResponse;
    }

    public override void Add(ChatMenuComponent chatMenuComponent)
    {
        chatMenuList.Add(chatMenuComponent);
    }

    public override void Remove(ChatMenuComponent chatMenuComponent)
    {
        chatMenuList.Remove(chatMenuComponent);
    }

    public override ChatMenuComponent GetChild(int i)
    {
        if (i < chatMenuList.Count)
        {
            return chatMenuList[i];
        }
        else return null;
    }

    public override string GetNPCResponseText()
    {
        return NPCMenuInitResponse;
    }

    public List<ChatMenuComponent> GetChatMenuList()
    {
        return chatMenuList;
    }

    public static ChatMenu GetRootChatMenu (Character c, string npcResponseText)
    {
        ChatMenu rootChatMenu = new ChatMenu(npcResponseText);
        rootChatMenu.Add(c.appearance);
        rootChatMenu.Add(c.profession);
        rootChatMenu.Add(c.lifeEvents);
        rootChatMenu.Add(c.parents);
        return rootChatMenu;

    }

}
