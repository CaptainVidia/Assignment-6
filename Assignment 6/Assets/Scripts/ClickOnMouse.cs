/*Name: George Tang
 * File: MouseClick.cs
 * Project: Assignment 5
 * Description: Allows the collector to select certain cards to either add or remove to their deck
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickOnMouse : MonoBehaviour
{
    public OpponentDeck opponentDeck;
    public PlayerDeck playerDeck;
    GameObject toSpawn;
    public Text playerManaText, opponentManaText;
    int opponentMana = 50, playerMana = 50;

    // Update is called once per frame
    void Update()
    {
        playerManaText.text = "Player Mana: " + playerMana;
        opponentManaText.text = "Opponent Mana: " + opponentMana;
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "PlayerMat")
                {
                    toSpawn = playerDeck.CreateEntity();
                    if (toSpawn.GetComponent<Entity>().CardCost() <= playerMana)
                    {
                        Instantiate(toSpawn, hitInfo.point, toSpawn.transform.rotation, null);
                        playerMana -= toSpawn.GetComponent<Entity>().CardCost();
                    }
                }
                else if (hitInfo.collider.gameObject.tag == "OpponentMat")
                {
                    toSpawn = opponentDeck.CreateEntity();
                    if (toSpawn.GetComponent<Entity>().CardCost() <= opponentMana)
                    {
                        Instantiate(toSpawn, hitInfo.point, toSpawn.transform.rotation, null);
                        opponentMana -= toSpawn.GetComponent<Entity>().CardCost();
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
