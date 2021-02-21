using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

abstract public class ChatMenuComponent
{
    public virtual void Add(ChatMenuComponent chatMenuComponent)
    {
        Debug.Log("ChatMenuComponent default add executed, you need to override this method!");
    }

    public virtual void Remove(ChatMenuComponent chatMenuComponent)
    {
        Debug.Log("ChatMenuComponent default remove executed, you need to override this method!");
    }

    public virtual ChatMenuComponent GetChild(int i)
    {
        Debug.Log("ChatMenuComponent default GetChild(int i) executed, you need to override this method!");
        ChatMenuComponent cmc = null;
        return cmc;
    }

    public virtual string GetButtonText()
    {
        Debug.Log("ChatMenuComponent default GetButtonText() executed, you need to override this method!");
        return "";
    }

    public virtual string GetNPCResponseText()
    {
        Debug.Log("ChatMenuComponent default GetNPCResponseText() executed, you need to override this method!");
        return "";
    }

    public virtual ChatMenu GetChatMenu(Character c)
    {
        Debug.Log("ChatMenuComponent default GetChatMenu() executed, you need to override this method!");
        ChatMenu cm = null;
        return cm;
    }

}
