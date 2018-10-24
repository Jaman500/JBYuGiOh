using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
	public int atk;
	public int def;
	public int level;
	public string type;
	public string name;
	public Monster enemy;
	public Player daddy;
	// Use this for initialization
	void Start()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
			this.Attack(enemy);
		}
	}

	//Calculation method for Battle Phase
	void Attack(Monster m)
	{
		Debug.Log("Fuck that bitch");
		if(atk > m.atk)
		{
			//attacked monster dies
			//destroy game object
			GameObject.Destroy(m.gameObject.transform.GetChild(0).gameObject);
			//other player loses life points
			int lpLoss = atk - m.atk;
			m.daddy.subLP(lpLoss);
		}
		else if(atk < m.atk)
		{
			//attacker dies
			//destroy game object
			GameObject.Destroy(this.gameObject.transform.GetChild(0).gameObject);
			//this player loses life points
			int lpLoss = m.atk - atk;
			daddy.subLP(lpLoss);
		}
		else
		{
			//they both die	
			//destroy both
			GameObject.Destroy(m.gameObject.transform.GetChild(0).gameObject);
			GameObject.Destroy(this.gameObject.transform.GetChild(0).gameObject);
			//no lifepoints lost
		}
	}

}
