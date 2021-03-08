using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentDeck : MonoBehaviour
{
    public GameObject[] entities;
    public int toInstantiate = 0;

    public GameObject CreateEntity()
    {
        GameObject obj;
        if (toInstantiate == 0)
        {
            obj = entities[0];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<OpponentMonster>();
        }
        else if (toInstantiate == 1)
        {
            obj = entities[1];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<OpponentSpell>();
        }
        else
        {
            obj = entities[2];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<OpponentSpecial>();
        }
        return obj;
    }

    public void MonsterChoice()
    {
        toInstantiate = 0;
    }

    public void SpellChoice()
    {
        toInstantiate = 1;
    }

    public void SpecialChoice()
    {
        toInstantiate = 2;
    }

    
}
