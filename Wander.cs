using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Wander : MonoBehaviour
{
    public TextAsset textFile;     // drop your file here in inspector
    GameObject AI;
    public bool finished = false;
    bool messageOver = true;
    public RawImage MessageBox;
    public Text Message;
    public Text Name;
    public Transform target;
    public GameObject Marker;
    public string AIname = "-";
    string msg = "";
    string[] splitArray;
    public string MName = "Marker";
    public float AIspeed = 3;
    float timeLeft = 0;
    void Start()
    {
        
        msg = textFile.text;  //this is the content as string
        splitArray = msg.Split(char.Parse("*"));
        AI = GameObject.Find(AIname);
        UIOff();
    }
    private void Update()
    {
        if (timeLeft < 0 && !messageOver)
        {
            UIOff();
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
    }
    void FixedUpdate()
    {
        if (!finished)
            goTowards();
    }

    void goTowards()
    {
        float step = AIspeed * Time.deltaTime;
        Vector3 targetDir = target.position - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
        transform.rotation = Quaternion.LookRotation(newDir);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == MName)
        {
            other.gameObject.GetComponent<Marker>().move = true;
            finished = true;
        }
    }

    void OnMouseDown()
    {
        messageOver = false;
        Name.enabled = true;
        Name.text = AIname;
        if(AIname == "Todd")
            Name.color = Color.red;
        else
            Name.color = Color.blue;
        Message.enabled = true;
        MessageBox.enabled = true;
        Message.text = splitArray[0];
        timeLeft = 5;
    }

    void UIOff()
    {
        messageOver = true;
        Name.enabled = false;
        Message.enabled = false;
        MessageBox.enabled = false;
    }
}