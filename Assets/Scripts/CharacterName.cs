using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterName : ChatMenuComponent
{
    public string characterName;
    public ChatMenu characterChatMenu;

    public CharacterName(string characterName)
    {
        this.characterName = characterName;
    }

    /**
     * GetChatMenu is not required for CharacterName
     * At least that's what I think...
     * There's no way to engage a character about their name.
     * They'll just give it to you at the start of the conversation. 
     * Unless we want to make talking about names an option
     * later on. A starter method is below if we go that route.
     */
    /**
    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu characterNameChatMenu = new ChatMenu(GetNPCResponseText());
        characterNameChatMenu.Add(c.attribute1);
        characterNameChatMenu.Add(c.attribute2);
        ...
        return characterNameChatMenu;
    }
    */

    public static CharacterName ReturnRandomCharacterName(Gender g)
    {
        string adjective = ReturnRandomAdjective();
        string genderedName;
        if (g.gender == "male")
        {
            genderedName = ReturnRandomMaleName();
        }
        else if ((g.gender == "female"))
        {
            genderedName = ReturnRandomFemaleName();
        }
        else
        {
            genderedName = "not yet implemented... error";
            Debug.Log("advanced gender module not yet implemented");
        }
        CharacterName randomCharacterName = new CharacterName(adjective + " " + genderedName);
        return randomCharacterName;

    }

    public static string ReturnRandomAdjective()
    {
        List<string> adjectiveList = new List<string>();
        adjectiveList.Add("Cantankerous");
        adjectiveList.Add("Recalcitrant");
        adjectiveList.Add("Obstreperous");
        adjectiveList.Add("Beligerant");
        adjectiveList.Add("Raging");
        adjectiveList.Add("Slippery");
        adjectiveList.Add("Greasy");

        string randomAdjective = adjectiveList[Random.Range(0, adjectiveList.Count)];
        return randomAdjective;
    }


    public static string ReturnRandomMaleName()
    {
        List<string> maleNameList = new List<string>();
        maleNameList.Add("Bob");
        maleNameList.Add("Doug");
        maleNameList.Add("John");
        maleNameList.Add("Jim");
        maleNameList.Add("Andy");
        maleNameList.Add("Rick");

        string randomMaleName = maleNameList[Random.Range(0, maleNameList.Count)];
        return randomMaleName;
    }

    public static string ReturnRandomFemaleName()
    {
        List<string> femaleNameList = new List<string>();
        femaleNameList.Add("Sue");
        femaleNameList.Add("Lani");
        femaleNameList.Add("Jazzy");
        femaleNameList.Add("Lou");
        femaleNameList.Add("Crystale");
        femaleNameList.Add("Keesha");

        string randomfemaleName = femaleNameList[Random.Range(0, femaleNameList.Count)];
        return randomfemaleName;
    }
    public override string GetNPCResponseText()
    {
        return "Hello, my name is " + characterName;
    }

    public override string GetButtonText()
    {
        return "What is your name?";
    }
}
