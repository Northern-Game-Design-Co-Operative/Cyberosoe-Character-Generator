using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullChatMenuComponent : ChatMenuComponent
{
    public string nullString;
    public ChatMenu chatMenu;
    public NullChatMenuComponent(string nullString)
    {
        this.nullString = nullString;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public override string GetNPCResponseText()
    {
        return "...";
    }

    public override string GetButtonText()
    {
        return "";
    }

}
