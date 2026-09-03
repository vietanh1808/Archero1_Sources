using UnityEngine;

public class GameTouch
{
	public int FingerId { get; set; }

	public string Phase { get; set; }

	public Vector3 WorldPos { get; set; }

	public float DeltaTime { get; set; }

	public Vector2 DeltaPos { get; set; }

	public Vector3 PixelPos { get; set; }
}
