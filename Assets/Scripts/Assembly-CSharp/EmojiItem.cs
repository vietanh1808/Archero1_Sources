using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EmojiItem : MonoBehaviour
{
	public ButtonCtrl itemBtn;

	public Image icon;

	public Image cdImage;

	[CompilerGenerated]
	private Action<int> m_OnPlayEmoji;

	private int id;

	private int index;

	private float cdTimer;

	private const float cdMax = 5f;

	public event Action<int> OnPlayEmoji
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init(int pIndex, int pId)
	{
	}

	private void OnClickItem()
	{
	}

	public void GoToCDState()
	{
	}

	public void SetCanClick(bool pCanClick)
	{
	}

	public void UpdateItem(float dt)
	{
	}
}
