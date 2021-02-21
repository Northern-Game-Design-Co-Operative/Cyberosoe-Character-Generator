using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public interface ISubject
{
    void registerObserver(IObserver iobserver);
    void removeObserver(IObserver iobserver);
    void notifyObservers(ChatMenu chatMenu);
}
