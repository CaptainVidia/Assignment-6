using UnityEngine;
using System.Collections;

public class OpponentSpell : Entity
{

    string Type = "Spell (BLUE)";
    string Ability = "activate or empower monster attacks and defenses";
    int Cost = 5;
    int numSet = 2;

    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
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
