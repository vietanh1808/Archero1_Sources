using System;
using UnityEngine;

public class LanguageOneCtrl : MonoBehaviour
{
	public DxxText Text_Language;

	public ButtonCtrl Button_Language;

	public GameObject fg;

	public Action<LanguageOneCtrl> OnClickButton;

	public string mLanguage { get; private set; }

	private void Awake()
	{
	}

	public void Init(int index, string language)
	{
	}

	private void UpdateChoose()
	{
	}
}
