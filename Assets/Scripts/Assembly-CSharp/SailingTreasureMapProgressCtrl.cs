using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingTreasureMapProgressCtrl : MonoBehaviour
{
	[SerializeField]
	private Image[] _imgPaths;

	[SerializeField]
	private Image _imgMask;

	[SerializeField]
	private Image _imgBox;

	[SerializeField]
	private GameObject _objBattle;

	[SerializeField]
	private DxxText _textDesc;

	[SerializeField]
	private Image _imgPos;

	[SerializeField]
	private GameObject _objEffect;

	private ShipBattle_TreasureMap _data;

	private Action<ShipBattle_TreasureMap, bool> _callback;

	private bool _unlock;

	public Vector3 TargetPos => default;

	public void OnClick()
	{
	}

	public void Init(int id, int minute, int distance, bool claimed, Action<ShipBattle_TreasureMap, bool> callback, bool first = false)
	{
	}

	public void Unlock()
	{
	}

	public void Close()
	{
	}
}
