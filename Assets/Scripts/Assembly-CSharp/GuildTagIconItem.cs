using System;
using UnityEngine;

public class GuildTagIconItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage icon;

	[SerializeField]
	private DxxText text;

	[SerializeField]
	private GameObject chosenTag;

	[SerializeField]
	private DxxImage bg;

	[SerializeField]
	private ButtonCtrl btn;

	public Action<int, bool> onClick;

	private int id;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void ToggleChosenTag(int id, bool wasShown)
	{
	}

	public void Set(int id, Action<int, bool> onClick)
	{
	}
}
