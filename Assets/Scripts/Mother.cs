using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mother : ChatMenuComponent
{
    public CharacterName name;
    public Race race;
    public Profession profession;
    public Demeanor demeanor;
    public Gender gender;

    public Mother(CharacterName name, Race race, Profession profession, Demeanor demeanor, Gender gender)
    {
        this.name = name;
        this.race = race;
        this.profession = profession;
        this.demeanor = demeanor;
        this.gender = gender;
    }

    public override ChatMenu GetChatMenu(Character c)
    {
        ChatMenu chatMenu = ChatMenu.GetRootChatMenu(c, GetNPCResponseText());
        return chatMenu;
    }

    public static Mother ReturnMother()
    {
        Gender gender = new Gender("female");
        CharacterName name = CharacterName.ReturnRandomCharacterName(gender);
        Race race = Race.ReturnRandomRace();
        Profession profession = Profession.ReturnRandomProfession();
        Demeanor demeanor = Demeanor.ReturnRandomDemeanor();
        return new Mother(name, race, profession, demeanor, gender);
    }

    public override string GetNPCResponseText()
    {
        return
            "My mother's name is " + name.characterName + ".\n" +
            "My mother's race is " + race.race + ".\n" +
            "My mother works as a " + profession.profession + ".\n" +
            "My mother's attitude is " + demeanor.demeanor + ".\n" +
            "My mother's gender is " + gender.gender + ".";
    }

    public override string GetButtonText()
    {
        return "Tell me about your mother.";
    }


}