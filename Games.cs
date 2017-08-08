using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Games : MonoBehaviour {
	
	public Sprite burg;
	public Sprite yell;
	public Sprite pink;
	public Sprite gren;
	public Sprite stek;
	public Sprite IT;
	public Sprite back;
	public Sprite clams;
	public Sprite Turkey;
	public Sprite Mystery;
	public Sprite Lamb;
	public Sprite Ham;
	public Sprite Bologna;

	public Button reset;

	public Text score;

	public float timer=0.0f;
	public int numberOpen=0;

	public GameObject[] stacksOnStacks=new GameObject[12];

	public int positionInStack=0;

	public int Counter = 0;
	// Use this for initialization
	void Start () {
		reset.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score: " + Counter;
		if (Counter >= 12) {
			score.text = "You Win!!!: ";
			reset.gameObject.SetActive (true);
		}

		if (numberOpen == 2) {
			timer += Time.deltaTime;

				if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("burg") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("burg")) {
					numberOpen = 0;
					Debug.Log ("Match");
					timer = 0.0f;
					positionInStack -= 2;
				Counter++;
				}
				else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("pink") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("pink")) {
					numberOpen = 0;
					Debug.Log ("Match");
					timer = 0.0f;
					positionInStack -= 2;
				Counter++;
				}
				else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("green") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("green")) {
					numberOpen = 0;
					Debug.Log ("Match");
					timer = 0.0f;
					positionInStack -= 2;
				Counter++;
				}
				else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("yellow") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("yellow")) {
					numberOpen = 0;
					Debug.Log ("Match");
					timer = 0.0f;
					positionInStack -= 2;
				Counter++;
				}
				else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("steak") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("steak")) {
					numberOpen = 0;
					Debug.Log ("Match");
					timer = 0.0f;
					positionInStack -= 2;
				Counter++;
				}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("rinsem") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("rinsem")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("ham") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("ham")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("turkey") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("turkey")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("clam") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("clam")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("bologna") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("bologna")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("mystery") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("mystery")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}
			else if (stacksOnStacks [positionInStack - 1].gameObject.name.StartsWith ("lamb") && stacksOnStacks [positionInStack - 2].gameObject.name.StartsWith ("lamb")) {
				numberOpen = 0;
				Debug.Log ("Match");
				timer = 0.0f;
				positionInStack -= 2;
				Counter++;
			}

				else {
				if (timer >= 2.0f) {
					numberOpen = 0;
					positionInStack--;

					stacksOnStacks [positionInStack].gameObject.GetComponent < Image > ().sprite = back;
					positionInStack--;
					stacksOnStacks [positionInStack].gameObject.GetComponent < Image > ().sprite = back;
					timer = 0.0f;
				}
			}
		}
	}
	public void Restartclick()
	{
		Application.LoadLevel ("Main");
	}
	public void HamClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = Ham;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void BolognaClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = Bologna;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void LambClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = Lamb;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void MysteryClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = Mystery;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void TurkeyClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = Turkey;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void ClamsClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = clams;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void BurgerClick(Button button)
	{
		if (timer == 0.0f) {
			button.GetComponent<Image> ().sprite = burg;
			numberOpen++;
			stacksOnStacks [positionInStack] = button.gameObject;
			positionInStack++;
		}
	}
	public void YellowDogClick(Button button)
	{
		if (timer == 0.0f) {
		numberOpen++;
		button.GetComponent<Image> ().sprite = yell;
		stacksOnStacks [positionInStack] = button.gameObject;
		positionInStack++;
		}}
	public void GreenDogClick(Button button)
	{
			if (timer == 0.0f) {
		numberOpen++;
		button.GetComponent<Image> ().sprite = gren;
		stacksOnStacks [positionInStack] = button.gameObject;
		positionInStack++;
			}}
	public void PinkDogClick(Button button)
	{
				if (timer == 0.0f) {
		numberOpen++;
		button.GetComponent<Image> ().sprite = pink;
		stacksOnStacks [positionInStack] = button.gameObject;
		positionInStack++;
				}}
	public void SteakClick(Button button)
	{
					if (timer == 0.0f) {
		numberOpen++;
		button.GetComponent<Image> ().sprite = stek;
		stacksOnStacks [positionInStack] = button.gameObject;
		positionInStack++;
					}}
	public void RinsemClick(Button button)
	{
						if (timer == 0.0f) {
		numberOpen++;
		button.GetComponent<Image> ().sprite = IT;
		stacksOnStacks [positionInStack] = button.gameObject;
		positionInStack++;
						}}


}
