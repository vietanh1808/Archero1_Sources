using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasRenderer))]
public class EmptyGraphic : MaskableGraphic
{
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	public override bool Raycast(Vector2 sp, Camera eventCamera)
	{
		return false;
	}
}
