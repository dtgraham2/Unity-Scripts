using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move : MonoBehaviour {
	public KeyCode upKey;
	public KeyCode downKey;
	public KeyCode rightKey;
	public KeyCode leftKey;
	public float speed = 16;
	int direction;
	public GameObject wallPrefab;

	Collider2D wall;
    
    Vector2 lastWallEnd;


	void Start () {
		direction = 1;
		GetComponent<Rigidbody2D>().velocity = Vector2.up * speed; 
		spawnWall ();
	}


	void Update () {
                 Vector2 moveDirection = GetComponent<Rigidbody2D>().velocity;
        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        if (!FindObjectOfType<Interface>().isFrozen())
        {
            if (Input.GetKeyDown(upKey) && direction != 2)
            {
                direction = 1;
                GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
                spawnWall();
            }
            else if (Input.GetKeyDown(downKey) && direction != 1)
            {
                transform.Rotate(Vector3.forward);
                direction = 2;
                GetComponent<Rigidbody2D>().velocity = -Vector2.up * speed;
                spawnWall();
            }
            else if (Input.GetKeyDown(rightKey) && direction != 4)
            {
                direction = 3;
                GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
                spawnWall();
            }
            else if (Input.GetKeyDown(leftKey) && direction != 3)
            {
                direction = 4;
                GetComponent<Rigidbody2D>().velocity = -Vector2.right * speed;
                spawnWall();
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.right * 0;
        }
            

        fitColliderBetween(wall, lastWallEnd, transform.position);
	}

	void spawnWall() {
        if (!FindObjectOfType<Interface>().isFrozen())
        {
            lastWallEnd = transform.position;
            GameObject g = (GameObject)Instantiate(wallPrefab, transform.position, Quaternion.identity);
            wall = g.GetComponent<Collider2D>();
        }
	}

	void fitColliderBetween(Collider2D co, Vector2 a, Vector2 b) {
		co.transform.position = a + (b - a) * 0.5f;

		float dist = Vector2.Distance (a, b);
		if (a.x != b.x)
			co.transform.localScale = new Vector2 (dist + 1, 1);
		else
			co.transform.localScale = new Vector2 (1, dist + 1);
	}

	void OnTriggerEnter2D(Collider2D co) {
		if (co != wall && !co.tag.Equals("power")) {
            FindObjectOfType<Interface>().Winner(name);
            Destroy(gameObject);
		}
		if (co.tag.Equals("walls")) {
            FindObjectOfType<Interface>().Winner(name);
            Destroy(gameObject);
		}
        if (co.tag.Equals("power"))
        {
            Destroy(co.gameObject);
            speed += 5;
        }
    }
		
}
