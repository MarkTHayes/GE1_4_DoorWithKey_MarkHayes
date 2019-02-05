using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {


    public static LevelManager instance;

    private GameObject player;
    private GameObject door;
    private GameObject key;
    private GameObject doorSwitch;

    public float speed;

    public bool hasKey;
    public bool hittingSwitch;


    private void Awake()
    {
        instance = this;
    }


    // Use this for initialization
    void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        door = GameObject.FindGameObjectWithTag("Door");
        key = GameObject.FindGameObjectWithTag("Key");
        doorSwitch = GameObject.FindGameObjectWithTag("Switch");




    }
	
	// Update is called once per frame
	void Update () {

        player.transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);

        InputManager();

		
	}


    public void PlayerHitKey()
    {

        hasKey = true;
        key.SetActive(false);

    }

    public void InputManager()
    {

        if (Input.GetKeyDown(KeyCode.Space) && hasKey && hittingSwitch)
        {



        }


    }





}
