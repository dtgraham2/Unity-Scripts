using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankStatus : MonoBehaviour {
    public int HP = 300;
    public GameObject thisTank;
    public GameObject Camera;
    public bool AI;
    public Slider Health;
	void Update () {
        if (HP <= 0)
        {
            if(!AI)
                Camera.transform.parent = null;
            Destroy(thisTank);
        }
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.transform.tag == "Bullet")
        {
            HP -= 25;
            Health.value = HP;
        }
    }
}
