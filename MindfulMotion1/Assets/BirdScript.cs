using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    // creating a reference to the rigid body
    public Rigidbody2D RB2D;
    //create a reference to the strenght of the push
    public float flapStrength;
    public LogicScript Logic;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame ; so happens all the time repeatedly
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            RB2D.velocity = Vector2.up * flapStrength;
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        Logic.Over();
    }
}
