using System;
using UnityEngine;

public class CharTrainStarUpTips : MonoBehaviour
{
	public CharStarShowItem starItem;

	public DxxText congratulations;

	public DxxText reachStarText;

	public DxxText anyKeyText;

	public DxxText skillText;

	private Action onClose;

	public void show(int star, string desc, Action callback = null)
	{
	}

	public void OnButtonClose()
	{
	}
}
