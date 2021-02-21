using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScript : MonoBehaviour, IObserver
{
    private TextMeshProUGUI buttonText;
    public ChatMenu newChatMenu = new ChatMenu("initialization error");
    int i;
    void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void updateObserver(ChatMenu newChatMenu, int i)
    {
        if (i < newChatMenu.GetChatMenuList().Count)
        {
            buttonText.text = newChatMenu.GetChild(i).GetButtonText();
        }
        this.newChatMenu = newChatMenu;
        this.i = i;
    }

    public void buttonClick()
    {
        Driver.GetRandomCharacter().notifyObservers(newChatMenu.GetChild(i).GetChatMenu(Driver.GetRandomCharacter()));
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }

    public void quit()
    {
        Application.Quit();
    }
}
