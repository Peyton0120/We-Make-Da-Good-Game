using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth = 4;
    public HealthBar healthBar;
    public bool axeActive = false;

    //Sets current health to max health at start
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    
    //Takes a set amount of damage
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    //Calls TakeDamage and checks for death
    public void Hurt()
    {
        TakeDamage(1);
        if (currentHealth <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    //Restores health
    void Heal()
    {
        if (currentHealth<= 3)
        {
            TakeDamage(-1);
        }
    }
    
    //Instant death from invisible pit
    void Fall()
    {
        TakeDamage(4);
        if (currentHealth <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    
    //Checks collision to take damage, heal, or rach the goal
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Master cross = collision.collider.GetComponent<Master>();
        if (cross != null)
        {
            Hurt();
        }
        Patrol patrol = collision.collider.GetComponent<Patrol>();
        if (patrol != null)
        {
            Hurt();
        }
        Health_Bottle healthBottle = collision.collider.GetComponent<Health_Bottle>();
        if (healthBottle != null)
        {
            Heal();
        }
        Pit pit = collision.collider.GetComponent<Pit>();
        if (pit != null)
        {
            Fall();
        }
        Goal goal = collision.collider.GetComponent<Goal>();
        if (goal != null)
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex + 1);
        }
        AxePickup axePickup = collision.collider.GetComponent<AxePickup>();
        if (axePickup != null)
        {
            axeActive = true;
        }
    }
}
