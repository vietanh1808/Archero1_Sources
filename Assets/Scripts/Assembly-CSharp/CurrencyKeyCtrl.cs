using System;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyKeyCtrl : MonoBehaviour
{
	[NonSerialized]
	public ProgressCtrl mProgressCtrl;

	[NonSerialized]
	public ProgressTextCtrl mProgressTextCtrl;

	private int mBeforeKey;

	private Image Image_Key;

	private void Awake()
	{
	}

	public void SetProgress(int current, int max)
	{
	}

	private void ChangeImage(int current)
	{
	}

	public void SetProgress(string text)
	{
	}
}
