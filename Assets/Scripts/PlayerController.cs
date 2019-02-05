using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Key")
        {

            LevelManager.instance.PlayerHitKey();

        }

        if (col.gameObject.tag == "Switch")
        {

            LevelManager.instance.hittingSwitch = true;

        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == "Switch")
        {

            LevelManager.instance.hittingSwitch = false;

        }

    }


}
