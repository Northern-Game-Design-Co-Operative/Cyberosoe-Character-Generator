using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demeanor
{
    public string demeanor;

    public Demeanor(string demeanor)
    {
        this.demeanor = demeanor;
    }

    public static Demeanor ReturnRandomDemeanor()
    {
        List<string> demeanorList = new List<string>();
        demeanorList.Add("happy");
        demeanorList.Add("positive");
        demeanorList.Add("indifferent");
        demeanorList.Add("angry");
        demeanorList.Add("abusive");
        demeanorList.Add("depressed");


        Demeanor randomDemeanor = new Demeanor(demeanorList[Random.Range(0, demeanorList.Count)]);

        return randomDemeanor;

    }
}
