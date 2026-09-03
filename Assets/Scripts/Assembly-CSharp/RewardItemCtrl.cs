using TableTool;
using UnityEngine;

public class RewardItemCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText txtCount;

	[SerializeField]
	private DxxText txtContent;

	[SerializeField]
	private DxxImage imgIcon;

	[SerializeField]
	private DxxImage imgGiftBack;

	[SerializeField]
	private DxxImage imgGiftType;

	[SerializeField]
	private GameObject goEffect;

	private Drop_DropModel.DropData data;

	public void Init(Drop_DropModel.DropData newData)
	{
	}

	public void OnLanguageUpdate()
	{
	}
}
