using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speed = 30;
    [SerializeField] private float attackDelay;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private bool attacking = false;
    [SerializeField] private bool canAttack = true;

    private Rigidbody2D rbody;
    [SerializeField] private GameObject playerAttack;

	// Use this for initialization
	void Awake ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Move();

        Attack();
	}

    void Move()
    {
        rbody.velocity = new Vector2(speed, 0);
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canAttack)
        {
            Vector3 attackVector = new Vector3(gameObject.transform.position.x + 55, gameObject.transform.position.y + 15, gameObject.transform.position.z);
            Instantiate(playerAttack, attackVector, Quaternion.identity);

            canAttack = false;
            attackDelay = 0.4f;
        }

        if (attackDelay > 0)
        {
            attackDelay -= Time.deltaTime;
        }

        else if (attackDelay <= 0)
        {
            canAttack = true;
            attackDelay = 0;
        }
    }
}
