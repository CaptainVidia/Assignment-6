using UnityEngine;
using System.Collections;

public class OpponentSpecial : Entity
{

    string Type = "Special (GREEN)";
    string Ability = "activate mosnter special ability";
    int Cost = 10;
    int numSet = 3;

    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
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
