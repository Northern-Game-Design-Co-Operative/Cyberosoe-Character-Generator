using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Father : ChatMenuComponent
{
    public CharacterName name;
    public Race race;
    public Profession profession;
    public Demeanor demeanor;
    public Gender gender;

    public Father(CharacterName name, Race race, Profession profession, Demeanor demeanor, Gender gender)
    {
        this.name = name;
        this.race = race;
        this.profession = profession;
        this.demeanor = demeanor;
        this.gender = gender;
    }

    public static Father ReturnFather()
    {
        Gender gender = new Gender("male");
        CharacterName name = CharacterName.ReturnRandomCharacterName(gender);
        Race race = Race.ReturnRandomRace();
        Profession profession = Profession.ReturnRandomProfession();
        Demeanor demeanor = Demeanor.ReturnRandomDemeanor();
        return new Father(name, race, profession, demeanor, gender);
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public override string GetNPCResponseText()
    {
        return
            "My father's name is " + name.characterName + ".\n" +
            "My father's race is " + race.race + ".\n" +
            "My father works as a " + profession.profession + ".\n" +
            "My father's attitude is " + demeanor.demeanor + ".\n" +
            "My father's gender is " + gender.gender + ".";
    }

    public override string GetButtonText()
    {
        return "Tell me about your father.";
    }


}