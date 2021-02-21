using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Driver : MonoBehaviour
{
    public static Character randomCharacter;

    public Button playerCommandButton1;
    public Button playerCommandButton2;
    public Button playerCommandButton3;
    public Button playerCommandButton4;
    public RectTransform chatBotResponseCanvas;

    public IObserver playerCommand1;
    public IObserver playerCommand2;
    public IObserver playerCommand3;
    public IObserver playerCommand4;
    public IObserver chatBotResponse;

    private ChatMenu startingChatMenu;

    // Start is called before the first frame update
    /**
     * Don't try changing the Start() below to an Awake().
     * There's a bunch of shit that needs to happen in the classes
     * before the driver can start.
     */
    void Start()
    {
        playerCommand1 = playerCommandButton1.GetComponent<IObserver>();
        playerCommand2 = playerCommandButton2.GetComponent<IObserver>();
        playerCommand3 = playerCommandButton3.GetComponent<IObserver>();
        playerCommand4 = playerCommandButton4.GetComponent<IObserver>();
        chatBotResponse = chatBotResponseCanvas.GetComponent<IObserver>();

        randomCharacter = Character.createRandomCharacter();
        randomCharacter.registerObserver(playerCommand1);
        randomCharacter.registerObserver(playerCommand2);
        randomCharacter.registerObserver(playerCommand3);
        randomCharacter.registerObserver(playerCommand4);
        randomCharacter.registerObserver(chatBotResponse);

        startingChatMenu = ChatMenu.GetRootChatMenu(randomCharacter, randomCharacter.characterName.GetNPCResponseText());
        randomCharacter.notifyObservers(startingChatMenu);

        //PrintCharacter(randomCharacter);
    }

    public static Character GetRandomCharacter()
    {
        return randomCharacter;
    }

    void PrintCharacter(Character c)
    {
        print(c.age);
        print("Mother's name: " + c.mother.name + " Mother's race: " + c.mother.race + " Mother's profession: " + c.mother.profession + " Mother's demeanor: " + c.mother.demeanor + " Mother's gender: " + c.mother.gender);
        print("Father's name: " + c.father.name + " Father's race: " + c.father.race + " Father's profession: " + c.father.profession + " Father's demeanor: " + c.father.demeanor + " Father's gender: " + c.father.gender);
        print("Character's race: " + c.race.race);
        print("Character's childhood experience: " + c.childhood.childhood);
        print("Character's adolescent experience: " + c.adolescence.adolescence);
        print("Character's adult experience: " + c.adulthood.adulthood);
        print("Character's old age experience: " + c.elder.oldage);
        print("Character's profession: " + c.profession.profession);
        print("Character's relationship status: " + c.relationshipStatus.relationshipStatus);
        print("Strength: " + c.stats.strength);
        print("Intelligence: " + c.stats.intelligence);
        print("Charisma: " + c.stats.charisma);
        print("Role in the game: "+ c.role.role);
        print("Character's demeanor: " + c.demeanor.demeanor);
        print("Character's gender: " + c.gender.gender);
        print("Place of residence: " + c.placeOfResidence.placeOfResidence);
    }
}
