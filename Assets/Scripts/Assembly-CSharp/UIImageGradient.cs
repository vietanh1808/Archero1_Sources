using UnityEngine;
using UnityEngine.UI;

public class UIImageGradient : BaseMeshEffect
{
	private enum Direction
	{
		Vertical = 0,
		Horizontal = 1
	}

	[SerializeField]
	private Direction mDirection;

	[SerializeField]
	private Color color;

	[SerializeField]
	private bool isMid;

	public override void ModifyMesh(VertexHelper vh)
	{
	}
}
