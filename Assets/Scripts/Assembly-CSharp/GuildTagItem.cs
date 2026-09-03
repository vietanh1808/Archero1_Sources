using System;
using UnityEngine;

public class GuildTagItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxImage imgBg;

	[SerializeField]
	private GameObject goSelection;

	[SerializeField]
	private DxxText txtTitle;

	public Func<bool, int, bool> onClick;

	private int id;

	private void Awake()
	{
	}

	public void Set(int id, bool selected)
	{
	}
}
