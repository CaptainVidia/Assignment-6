using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
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
            obj.AddComponent<PlayerMonster>();
        }
        else if (toInstantiate == 1)
        {
            obj = entities[1];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<PlayerSpell>();
        }
        else
        {
            obj = entities[2];
            if (obj.GetComponent<Entity>() != null)
                DestroyImmediate(obj.GetComponent<Entity>(), true);
            obj.AddComponent<PlayerSpecial>();
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

    public void Special()
    {
        toInstantiate = 2;
    }
}