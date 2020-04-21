using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
	public Transform player;
	public bool isFlipped = false;
	public Transform firePoint;
	public GameObject crossPrefab;
	public int maxHealth = 50;
	public int currentHealth = 50;
	public HealthBar healthBar;

	//Sets current health to max health at entry
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	//Resets healthbar to current health
	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

	//Deals damage and checks for death
	public void Hurt()
	{
		TakeDamage(2);
		if (currentHealth <= 0)
		{
			Destroy(gameObject);
		}
	}

	//Checks player position and flips movement accordingly
	public void LookAtPlayer()
	{
		Vector3 flipped = transform.localScale;
		flipped.z *= -1f;

		if (transform.position.x > player.position.x && isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = false;
		}
		else if (transform.position.x < player.position.x && !isFlipped)
		{
			transform.localScale = flipped;
			transform.Rotate(0f, 180f, 0f);
			isFlipped = true;
		}
	}
	

	//Spawns a cross
	void shoot()
	{ 
			Instantiate(crossPrefab, firePoint.position, firePoint.rotation);
	}
}
