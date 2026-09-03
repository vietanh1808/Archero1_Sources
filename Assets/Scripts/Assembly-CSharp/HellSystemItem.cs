using System;
using UnityEngine;

public sealed class HellSystemItem : MonoBehaviour
{
	[Header("模块Item")]
	public HeroOrAssistSystemItem heroOrAssistItem;

	public HeroSkinSystemItem heroSkinItem;

	public ManorBuildSystemItem ManorBuildItem;

	public GemSystemItem GemItem;

	public RefineSystemItem RefineItem;

	public PetSystemItem petItem;

	public ImprintItem imprintItem;

	public HellEquipSystemItem equipItem;

	public ManorWorkerSystemItem ManorWorkerItem;

	public HellWingsAndRelicsSystemItem wingsAndRelicsItem;

	private HellSystemItemData crtData;

	private int rowPos;

	public void Init(HellSystemItemData itemData, HellSystemBuffType hType, Action<HellSystemItemData, Vector3, int> callBack)
	{
	}

	public void SetRowPos(int pos)
	{
	}
}
