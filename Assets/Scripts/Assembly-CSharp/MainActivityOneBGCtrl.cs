using TableTool;
using UnityEngine;

public class MainActivityOneBGCtrl : MonoBehaviour
{
	public Transform child;

	public DxxImage Image_BG;

	public PropOneEquip mEquip;

	[SerializeField]
	private DxxText _textRate;

	public void Init(string reward, string sourceName, string rewardId)
	{
	}

	public void InitGuildBox((int, int) values)
	{
	}

	public void Init(Drop_DropModel.DropData data)
	{
	}

	public void InitChestBox(string reward, float rate = 0f)
	{
	}
}
