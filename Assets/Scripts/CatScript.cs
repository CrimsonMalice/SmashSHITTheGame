using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour {

    [SerializeField] public bool killCat = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (killCat)
        {
            gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            gameObject.transform.position += new Vector3(15, 15, 0);
        }

        if (gameObject.transform.localScale.x <= 0f)
        {
            Destroy(gameObject);
        }
	}
}
