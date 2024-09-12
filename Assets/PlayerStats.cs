using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float maxHealth;
    public float health;
    public Logic logic;
    public bool playerISAlive = true;

    private bool canTakeDamage = true;

    private Animator anim;

    void Start()
    {
        anim = GetComponentInParent<Animator>();
        health = maxHealth;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }
    public void TakeDamage(float damage)
    {
        if(!canTakeDamage)
        {
            return;
        }

        health -= damage;
        anim.SetBool("Damage", true);
        if(health <= 0)
        {
            GetComponent<PolygonCollider2D>().enabled = false;
            GetComponentInParent<GatherInput>().DisableControls();
            Debug.Log("Player is dead");
            playerISAlive = false;
            logic.gameOver();
        }
        StartCoroutine(DamagePrevention());
        
    }
    private IEnumerator DamagePrevention() 
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(0.15f);
        if (health > 0)
        {
            canTakeDamage = true;
            anim.SetBool("Damage", false);
            Debug.Log(health);
        }
        else 
        {
            anim.SetBool("Death", true);
            Debug.Log("Player is dead");
        }
    }
    
}


