using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationshipStatus
{
    public string relationshipStatus;

    public RelationshipStatus(string relationshipStatus)
    {
        this.relationshipStatus = relationshipStatus;
    }

    public static RelationshipStatus ReturnRandomRelationshipStatus()
    {
        List<string> relationshipStatusList = new List<string>();
        relationshipStatusList.Add("single");
        relationshipStatusList.Add("married");

        RelationshipStatus randomRelationshipStatus = new RelationshipStatus(relationshipStatusList[Random.Range(0, relationshipStatusList.Count)]);

        return randomRelationshipStatus;

    }

}
