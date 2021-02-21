using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Character : ISubject
{
    public CharacterName characterName;
    public Age age;

    public Parents parents;
    public Mother mother;
    public Father father;

    public Appearance appearance;

    public Race race;

    public LifeEvents lifeEvents;

    public Childhood childhood;
    public Adolescence adolescence;
    public Adulthood adulthood;
    public OldAge elder;

    public Profession profession;

    public RelationshipStatus relationshipStatus;

    public Stats stats;

    public Role role;

    public Demeanor demeanor;

    public Gender gender;

    public PlaceOfResidence placeOfResidence;

    public NullChatMenuComponent nullChatMenuComponent;

    private List<IObserver> observerList = new List<IObserver>();

    public Character(CharacterName characterName, Age age, Parents parents, Mother mother, Father father, Appearance appearance, Race race, LifeEvents lifeEvents, Childhood childhood, Adolescence adolescence, Adulthood adulthood, OldAge elder, Profession profession, RelationshipStatus relationshipStatus, Stats stats, Role role, Demeanor demeanor, Gender gender, PlaceOfResidence placeOfResidence, NullChatMenuComponent nullChatMenuComponent)
    {
        this.characterName = characterName;
        this.age = age;
        this.parents = parents;
        this.mother = mother;
        this.father = father;
        this.appearance = appearance;
        this.race = race;
        this.lifeEvents = lifeEvents;
        this.childhood = childhood;
        this.adolescence = adolescence;
        this.adulthood = adulthood;
        this.elder = elder;
        this.profession = profession;
        this.relationshipStatus = relationshipStatus;
        this.stats = stats;
        this.role = role;
        this.demeanor = demeanor;
        this.gender = gender;
        this.placeOfResidence = placeOfResidence;
        this.nullChatMenuComponent = nullChatMenuComponent;
    }

    public void registerObserver(IObserver iobserver)
    {
        observerList.Add(iobserver);
    }
    public void removeObserver(IObserver iobserver)
    {
        int i = observerList.IndexOf(iobserver);
        if (i >= 0)
        {
            observerList.RemoveAt(i);
        }
    }
    public void notifyObservers(ChatMenu chatMenu)
    {
        /**
         * This is pretty tricky conceptually. We'll have to loop back around to this.
         * This is coded a little weird. It'll work for now though.
         */
        for (int i = 0; i < observerList.Count; i++)
        {
            if (i < chatMenu.GetChatMenuList().Count)
            {
                observerList[i].updateObserver(chatMenu, i);
            }
        }
        //This extra statement is separate, It updates the chatbotresponse.
        //It always has to do this... without any conditions.
        observerList[observerList.Count-1].updateObserver(chatMenu, observerList.Count);
    }

    public static Character createRandomCharacter()
    {
        /**
         * We want to setup these values in a very particular sequence. 
         * i.e. What is said in life events depends on age.
         * i.e. A character's name depends on their gender.
         * etc. etc.
         */

        Age age = Age.ReturnRandomAge();
        Mother mother = Mother.ReturnMother();
        Father father = Father.ReturnFather();
        Parents parents = Parents.ReturnRandomParentsComment();
        Appearance appearance = Appearance.ReturnRandomAppearanceComment();
        Race race = Race.ReturnRandomRace();
        LifeEvents lifeEvents = LifeEvents.ReturnRandomLifeEventsComment();
        Childhood childhood = Childhood.ReturnRandomChildhoodEvent();
        Adolescence adolescence = Adolescence.ReturnRandomAdolescenceEvent();
        Adulthood adulthood = Adulthood.ReturnRandomAdulthoodEvent();
        OldAge elder = OldAge.ReturnRandomElderlyEvent();
        Profession profession = Profession.ReturnRandomProfession();
        RelationshipStatus relationshipStatus = RelationshipStatus.ReturnRandomRelationshipStatus();
        Stats stats = Stats.GenerateRandomStats();
        Role role = Role.ReturnRandomRole();
        Demeanor demeanor = Demeanor.ReturnRandomDemeanor();
        Gender gender = Gender.ReturnRandomGender();
        CharacterName characterName = CharacterName.ReturnRandomCharacterName(gender);
        PlaceOfResidence placeOfResidence = PlaceOfResidence.ReturnRandomPlaceOfResidence();
        NullChatMenuComponent nullChatMenuComponent = new NullChatMenuComponent("");

        Character randomCharacter;
        randomCharacter = new Character(characterName, age, parents, mother, father, appearance, race, lifeEvents, childhood, adolescence, adulthood, elder, profession, relationshipStatus, stats, role, demeanor, gender, placeOfResidence, nullChatMenuComponent);
        return randomCharacter;
    }
}
