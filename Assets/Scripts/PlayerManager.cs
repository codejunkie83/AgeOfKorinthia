using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerManager : MonoBehaviour {
    int health = 100;
    public Slider healthBar;
    NavMeshAgent agent;
    public GameObject Projectile;

	// Use this for initialization
	void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        healthBar.value = health;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                if (hit.transform.tag == "Enemy")
                {
                    transform.LookAt(hit.transform);
                    GameObject fireball = Instantiate(Projectile, transform.position, transform.rotation) as GameObject;
                    fireball.GetComponent<Rigidbody>().velocity = (hit.transform.position - transform.position).normalized * 10;
                }
                else
                {
                    agent.destination = hit.point;
                }
            }
        }
    }

    void ChangeHealth(int amount)
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
