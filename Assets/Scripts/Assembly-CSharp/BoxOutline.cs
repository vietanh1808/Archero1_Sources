using System.Collections.Generic;
using UnityEngine;

public class BoxOutline : ModifiedShadow
{
	private const int maxHalfSampleCount = 20;

	[SerializeField]
	[Range(1f, 20f)]
	private int m_halfSampleCountX;

	[SerializeField]
	[Range(1f, 20f)]
	private int m_halfSampleCountY;

	public int halfSampleCountX
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int halfSampleCountY
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void ModifyVertices(List<UIVertex> verts)
	{
	}
}
