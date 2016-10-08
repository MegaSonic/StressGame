using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ButtonManager : MonoBehaviour {

	public Text startText;

	public Text exitText;

	public Text creditText;

	public Text returnText;

	public void StartGame()
	{
		SceneManager.LoadScene ("MainGame");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	public void MoveToCredit()
	{
		SceneManager.LoadScene ("Credit");
	}

	public void ReturnToMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}

	public void ChangeStartTextColor()
	{
		startText.color = Color.white;
	}

	public void ChangeBackStartTextColor()
	{
		startText.color = Color.black;
	}

	public void ChangeExitTextColor()
	{
		exitText.color = Color.white;
	}

	public void ChangeBackExitTextColor()
	{
		exitText.color = Color.black;
	}

	public void ChangeReturnTextColor()
	{
		returnText.color = Color.white;
	}

	public void ChangeBackReturnTextColor()
	{
		returnText.color = Color.black;
	}

	public void ChangeCreditTextColor()
	{
		creditText.color = Color.white;
	}

	public void ChangeBackCreditTextColor()
	{
		creditText.color = Color.black;
	}
}
