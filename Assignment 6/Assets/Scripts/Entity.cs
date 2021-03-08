using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Entity : MonoBehaviour
{
    public abstract string CardType();
    public abstract string CardAbility();
    public abstract int CardCost();
    public abstract int CardNumSet();
}
