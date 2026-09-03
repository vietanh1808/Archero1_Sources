using System.Collections.Generic;
using UnityEngine;

public class PlinkoConfig : MonoBehaviour
{
	[Header("自由落体, 用于球刚出来的动画")]
	[SerializeField]
	private List<PlinkoMoveInfo> freeFall;

	[Header("左上")]
	[SerializeField]
	private List<PlinkoMoveInfo> leftTop;

	[SerializeField]
	[Header("右上")]
	[Space]
	private List<PlinkoMoveInfo> rightTop;

	[Space]
	[SerializeField]
	[Header("左")]
	private List<PlinkoMoveInfo> left;

	[Header("右")]
	[Space]
	[SerializeField]
	private List<PlinkoMoveInfo> right;

	[Header("左下")]
	[Space]
	[SerializeField]
	private List<PlinkoMoveInfo> leftBottom;

	[Header("右下")]
	[Space]
	[SerializeField]
	private List<PlinkoMoveInfo> rightBottom;

	[Header("原地")]
	[Space]
	[SerializeField]
	private List<PlinkoMoveInfo> stay;

	public PlinkoMoveInfo GetPlinkoMoveInfo(PlinkoMoveType type, int id)
	{
		return null;
	}

	public PlinkoMoveInfo GetPlinkoMoveInfo(PlinkoMoveType type)
	{
		return null;
	}
}
