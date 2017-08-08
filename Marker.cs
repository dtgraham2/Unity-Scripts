using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour {
    GameObject AI;
    public string AIName = "Todd";
    public bool move = false;
    public Vector3 Movement = new Vector3(0, 0, 0);
    public float AIspeed = 3;
    float step = 0;
    private void Update()
    {
        if (Input.GetKeyDown("space"))
            print("space key was pressed");
    }
    void Start()
    {
        Movement.x = Random.Range(-10.0f, 10.0f);
        AI = GameObject.Find(AIName);
        step = AIspeed * Time.deltaTime;
    }
    void FixedUpdate()
    {
        if (move && transform.position != Movement)
        {
            transform.position = Vector3.MoveTowards(transform.position, Movement, step);
        }
        else
        {
            move = false;
            AI.gameObject.GetComponent<Wander>().finished = false;
            Movement.x = Random.Range(-10.0f, 36.0f);
            Movement.z = Random.Range(-21.0f, 24.0f);
        }
    }

}
