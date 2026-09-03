using System.Collections.Generic;
using DG.Tweening;
using TableTool;
using UnityEngine;

public class BoxOpenGetCtrl : MonoBehaviour
{
	public const float ItemWidth = 150f;

	public const float ItemHeight = 150f;

	public const int LineCount = 4;

	public GameObject child;

	public DxxText Text_Title;

	public Transform getparent;

	private GameObject _copyitem;

	private LocalUnityObjctPool mPool;

	private GameObject copyitem => null;

	private void Awake()
	{
	}

	public Sequence Init(List<Drop_DropModel.DropData> list)
	{
		return null;
	}

	public void Show(bool value)
	{
	}
}
