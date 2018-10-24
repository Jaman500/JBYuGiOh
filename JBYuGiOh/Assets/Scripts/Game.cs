using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject[] players;

    int turnNum;

	// Use this for initialization
	void Start ()
    {
        if (players.Length <= 2)
        {
            Debug.LogError("There must be at least 2 Player GameObjects attached to the Game.cs script to start the game");
            Application.Quit();
        }

        turnNum = 0;
	}
	
    public void advanceTurn()
    {
        turnNum++;
    }

    // Calculate the value of the player whose turn it currently is
	public int getPlayerTurn()
    {
        return turnNum % players.Length;
    }
}
