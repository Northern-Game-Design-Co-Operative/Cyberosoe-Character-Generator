using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceOfResidence
{
    public string placeOfResidence;

    public PlaceOfResidence(string placeOfResidence)
    {
        this.placeOfResidence = placeOfResidence;
    }

    public static PlaceOfResidence ReturnRandomPlaceOfResidence()
    {
        List<string> placeOfResidenceList = new List<string>();
        placeOfResidenceList.Add("the frozen wastelands");
        placeOfResidenceList.Add("the barren planes");
        placeOfResidenceList.Add("cyberspace");
        placeOfResidenceList.Add("the scrapyard");
        placeOfResidenceList.Add("the wreckage of an abandoned city");
        placeOfResidenceList.Add("an underground bunker");
        placeOfResidenceList.Add("a magnificent skyscraper in the business district");

        PlaceOfResidence randomPlaceOfResidence = new PlaceOfResidence(placeOfResidenceList[Random.Range(0, placeOfResidenceList.Count)]);

        return randomPlaceOfResidence;

    }
}
