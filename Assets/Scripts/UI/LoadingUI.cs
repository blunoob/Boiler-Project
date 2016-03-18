﻿/* 		
		Author : Farhan
		Skype : farhan.blu
		Email : farhan.blu@gmail.com
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LoadingUI : MonoBehaviour 
{
	public Text _tipMessage;

	private static List<string> _tipMessages;
	static LoadingUI()
	{
		_tipMessages = new List<string>();
		_tipMessages.Add("You can logout from the settings menu");
		_tipMessages.Add("Relax");
		_tipMessages.Add("Flaming is discouraged.");
	}


	public void Show()
	{
		Show (_tipMessages.GetRandom());
	}


	public void Show(string tipMessage)
	{
		if(!gameObject.activeInHierarchy)
		{
			gameObject.SetActive(true);
			_tipMessage.text = tipMessage;
		}
	}
}
