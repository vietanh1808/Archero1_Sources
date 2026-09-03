using Dxx.Util;
using TableTool;
using UnityEngine;

public class Act5thHuntingDrop : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup canvasGroup;

	[SerializeField]
	private PropOneEquip drop;

	private SequencePool sequencePool;

	private Drop_DropModel.DropData dropProp;

	private Vector2 startPos;

	private float radius;

	private bool isInit;

	private int index;

	private void Init()
	{
	}

	public void Refresh(Drop_DropModel.DropData dropProp, Vector2 startPos, float radius, int index)
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshStatus()
	{
	}

	private void PlayAni()
	{
	}

	private Vector2 GetMiddlePos()
	{
		return default;
	}

	private Vector2 GetEndPos()
	{
		return default;
	}

	public void Recycle()
	{
	}
}
