using UnityEngine;
using System.Collections;

public class OpponentMonster : Entity
{
    string Type = "Monster (RED)";
    string Ability = "Monster to attack other players or player's mosnters";
    int Cost = 5;
    int numSet = 1;

    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public override string CardType()
    {
        return Type;
    }

    public override string CardAbility()
    {
        return Ability;
    }

    public override int CardCost()
    {
        return Cost;
    }

    public override int CardNumSet()
    {
        return numSet;
    }
}
