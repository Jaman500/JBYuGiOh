using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int lifePoints;
	
	// Use this for initialization
	void Start () 
	{
		lifePoints = 8000;
	}
	
	public void addLP(int x)
	{
		lifePoints += x;
	}

	public void subLP(int x)
	{
		lifePoints -= x;
	}

	public void checkLoser()
	{
		if(lifePoints < 0)
		{
			Debug.Log("YOU LOSE");
		}
	}

	public void checkMaxLP()
	{
		if(lifePoints > 10000)
		{
			lifePoints = 10000;
		}
	}

	//createMonster()
}
