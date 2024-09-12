using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spike : MonoBehaviour
{
    public float damage = 10f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerStats"))
        {
            collision.GetComponent<PlayerStats>().TakeDamage(damage);
            Debug.Log($"{damage}");
        }
    }
    void Start()
    {
        
    }
}

