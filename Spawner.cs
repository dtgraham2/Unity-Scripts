using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Spawner : MonoBehaviour {
    public string levelToLoad = "";
    public GameObject[] groups;

	public float Minutes = 1;
	public float timeLeft = 60;
    float score = 0;

    int lineNum = 0;
    int i;

    public Text textLines;
    public Text textTime;
    public Text textScore;

	public Sprite[] Images;
	public Image nextImage;

    public void spawnNext()
	{
		Instantiate (groups [i], transform.position, Quaternion.identity);
		i = Random.Range (0, groups.Length);
		nextImage.sprite = Images [i];
    }

	void Start()
	{
        i = Random.Range (0, groups.Length);
		spawnNext ();
	}

	void Update()
	{
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0) {
			if (Minutes > 0) {
				Minutes--;
				timeLeft = 60;
			} else {
                SceneManager.LoadScene(levelToLoad);
            }
		}
		textTime.text = (int)Minutes + ":" + (int)timeLeft;
        textScore.text = "Score: " + score;
        textLines.text = "Lines: " + lineNum;
    }

    public void lineChecker()
    {
        score += 100;
        lineNum += 1;
    }
    }

