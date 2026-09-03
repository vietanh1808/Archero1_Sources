using System;
using UnityEngine;

public class HellStageBuffItem : MonoBehaviour
{
	public ButtonCtrl btn_Click;

	public DxxImage Image_Buff;

	public DxxText txt_LeftNum;

	public DxxText txt_Level;

	public DxxImage img_Level;

	public GameObject starParent;

	public DxxImage starIcon;

	private HellLevelData crtData;

	private LocalUnityObjctPool _pool;

	private bool _isInit;

	public void Init(HellLevelData data, Action<HellLevelData, Vector3> clickAction)
	{
	}
}
