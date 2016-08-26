using UnityEngine;
using System.Collections;

public class FireballManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            EnemyManager em = other.gameObject.GetComponent<EnemyManager>();
            em.ChangeHealth(-15);
            Destroy(gameObject);
        }
    }
}
