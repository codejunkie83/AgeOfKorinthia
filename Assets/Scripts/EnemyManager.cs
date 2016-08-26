using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyManager : MonoBehaviour {
    int health = 100;
    public Slider healthBar;
    NavMeshAgent agent;
    public GameObject Projectile;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = health;
    }

    public void ChangeHealth(int amount)
    {
        health += amount;
        if (health < 0)
        {
            health = 0;
        }
        else if (health > 100)
        {
            health = 100;
        }
    }
}
