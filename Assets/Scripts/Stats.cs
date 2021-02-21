using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : ChatMenuComponent
{
    public int strength;
    public int intelligence;
    public int charisma;
    public ChatMenu chatMenu;

    public Stats (int strength, int intelligence, int charisma)
    {
        this.strength = strength;
        this.intelligence = intelligence;
        this.charisma = charisma;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Stats GenerateRandomStats()
    {
        int strength = Random.Range(1, 100);
        int intelligence = Random.Range(1, 100);
        int charisma = Random.Range(1, 100);

        Stats randomStats = new Stats(strength, intelligence, charisma);

        return randomStats;
    }

    public override string GetNPCResponseText()
    {
        return
            "Strength: " + strength.ToString() + ".\n" +
            "Intelligence " + intelligence.ToString() + ".\n" +
            "Charisma " + charisma.ToString() + ".\n";
    }

    public override string GetButtonText()
    {
        return "Stats";
    }
}
