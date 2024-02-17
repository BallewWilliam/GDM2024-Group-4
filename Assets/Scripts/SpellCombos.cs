using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum SpellType
{
	None,
	Steel,
	Tornado,
	Steam,
	Flamethrower,
	Lightning,
	Ice,
	Fire,
	Water,
	Earth,
	Air
}

public class SpellCombos : MonoBehaviour
{
	public Button spellButton1;
	public Button spellButton2;
	public Health healthScript; // Reference to the Health script

	private SpellType playerSpell1;
	private SpellType playerSpell2;

	private SpellType opponentSpell1;
	private SpellType opponentSpell2;

	void Start()
	{
		// Attach the onClick listeners to the buttons
		spellButton1.onClick.AddListener(OnSpellButton1Click);
		spellButton2.onClick.AddListener(OnSpellButton2Click);

		// Simulate opponent choosing spells (you can replace this with your logic)
		opponentSpell1 = GetRandomSpell();
		opponentSpell2 = GetRandomSpell();
	}

	void Update()
	{
		// Check if both player and opponent have selected spells
		if (playerSpell1 != 0 && playerSpell2 != 0 && opponentSpell1 != 0 && opponentSpell2 != 0)
		{
			// Calculate damage based on spell combination
			int playerDamage = CalculateDamage(playerSpell1, playerSpell2, opponentSpell1, opponentSpell2);

			// Reduce opponent's health based on calculated damage
			healthScript.TakeDamage(playerDamage);

			// Reset spell selections for future rounds
			ResetSpellSelections();
		}
	}

	void OnSpellButton1Click()
	{
		// Set playerSpell1 to the selected spell type
		playerSpell1 = GetRandomSpell(); // Replace this with your logic for spell selection
		Debug.Log("Player selected Spell 1: " + playerSpell1);
	}

	void OnSpellButton2Click()
	{
		// Set playerSpell2 to the selected spell type
		playerSpell2 = GetRandomSpell(); // Replace this with your logic for spell selection
		Debug.Log("Player selected Spell 2: " + playerSpell2);
	}

	SpellType GetRandomSpell()
	{
		// Return a random spell type
		return (SpellType)Random.Range(1, System.Enum.GetValues(typeof(SpellType)).Length);
	}

	int CalculateDamage(SpellType playerSpell1, SpellType playerSpell2, SpellType opponentSpell1, SpellType opponentSpell2)
	{
		// Combine player's selected spells
		SpellType playerCombinedSpell = CombineSpells(playerSpell1, playerSpell2);

		// Combine opponent's selected spells
		SpellType opponentCombinedSpell = CombineSpells(opponentSpell1, opponentSpell2);

		// Implement your logic for calculating damage based on combined spell interactions
		// This is a simple example, you can adjust it based on your game's mechanics
		int playerDamage = 10; // Default damage

		if (playerCombinedSpell == opponentCombinedSpell)
		{
			playerDamage *= 2; // Double the damage for matching combinations
		}

		return playerDamage;
	}

	SpellType CombineSpells(SpellType spell1, SpellType spell2)
	{
		// Implement your logic for spell combinations
		// This is a simple example, you can adjust it based on your game's mechanics

		if ((spell1 == SpellType.Fire && spell2 == SpellType.Earth) || (spell1 == SpellType.Earth && spell2 == SpellType.Fire))
		{
			return SpellType.Steel;
		}
		else if ((spell1 == SpellType.Air && spell2 == SpellType.Water) || (spell1 == SpellType.Water && spell2 == SpellType.Air))
		{
			return SpellType.Lightning;
		}
		else if ((spell1 == SpellType.Fire && spell2 == SpellType.Air) || (spell1 == SpellType.Air && spell2 == SpellType.Fire))
		{
			return SpellType.Flamethrower;
		}
		else if ((spell1 == SpellType.Air && spell2 == SpellType.Earth) || (spell1 == SpellType.Earth && spell2 == SpellType.Air))
		{
			return SpellType.Tornado;
		}
		else if ((spell1 == SpellType.Water && spell2 == SpellType.Earth) || (spell1 == SpellType.Earth && spell2 == SpellType.Water))
		{
			return SpellType.Ice;
		}
		else if ((spell1 == SpellType.Fire && spell2 == SpellType.Water) || (spell1 == SpellType.Water && spell2 == SpellType.Fire))
		{
			return SpellType.Steam;
		}

		return SpellType.None; // Default if no combination is found
	}

	void ResetSpellSelections()
	{
		// Reset spell selections for both player and opponent
		playerSpell1 = 0;
		playerSpell2 = 0;

		opponentSpell1 = GetRandomSpell();
		opponentSpell2 = GetRandomSpell();
	}
}

