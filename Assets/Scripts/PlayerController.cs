using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] private float speed = 30;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private bool attacking = false;

    private Rigidbody2D rbody;

	// Use this for initialization
	void Awake ()
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Move();
	}

    void Move()
    {
        rbody.velocity = new Vector2(speed, 0);
    }
}
