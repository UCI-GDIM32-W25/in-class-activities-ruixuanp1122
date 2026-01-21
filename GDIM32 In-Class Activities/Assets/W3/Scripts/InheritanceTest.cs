
using UnityEngine;

public class InheritanceTest : MonoBehaviour
{
	private void Start()
	{
		Player player = new Player();
		Enemy enemy = new Enemy();
		Villager villager = new Villager();
		
		player.TalkToNpc(enemy);
		player.TalkToNpc(villager);
	}
}

public class Player 
{
	private string _name = "Travis";
	public virtual void TalkToNpc (Npc npc)
	{
		npc.Talk(_name);
	}
}

public class Npc
{
	public virtual void Talk(string playerName) {}
}

public class Villager: Npc
{	
	public override void Talk(string playerName)
    {
        Debug.Log("Villager: Hello " + playerName + "! It's a beautiful day in the village.");
    }
}

// CHANGE THINGS IN ENEMY...
public class Enemy: Npc
{
    public override void Talk(string playerName)
    {
        Debug.Log("Enemy: Prepare to fight, " + playerName + "! You shouldn't have come here!");
    }
}