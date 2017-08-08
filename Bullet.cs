using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public GameObject old;
    int bounceCount = 0;
    void Start()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.transform.tag == "Environment")
        {
            bounceCount++;
            if (bounceCount > 1)
            {
                Destroy(old);
            }
        }

        if (col.collider.transform.tag == "Player")
        {
            Destroy(old);
        }
    }
}
