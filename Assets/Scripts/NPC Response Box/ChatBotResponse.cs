using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBotResponse : MonoBehaviour, IObserver
{
    private TextMeshProUGUI npcResponseText;

    void Awake()
    {
        npcResponseText = GetComponentInChildren<TextMeshProUGUI>();
    }
    public void updateObserver(ChatMenu cm, int i)
    {
        Debug.Log(cm.GetNPCResponseText());
        npcResponseText.text = cm.GetNPCResponseText();
    }
}
