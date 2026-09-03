using UnityEngine;

public class HID_UIFrameItem : ScriptableObject
{
	public const float OneFrameSecond = 0.03333333f;

	public HIDUEType type;

	public int startFrame;

	public int endFrame;

	public AnimationCurve curve;

	public Vector2 AnimStartScale;

	public string desc;

	public float startTime => 0f;

	public float endTime => 0f;

	public int durationFrame => 0;

	public float durationTime => 0f;

	public static void ReverseAnim(HID_UIFrameItem[] input, out HID_UIFrameItem[] output)
	{
		output = null;
	}
}
