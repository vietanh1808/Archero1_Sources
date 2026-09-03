using System;
using System.Collections.Generic;

[Serializable]
public class AnimationFrameInfo
{
	public string Name;

	public int StartFrame;

	public int EndFrame;

	public int FrameCount;

	public float Speed;

	public List<AnimationFrameInfoKey> Keys;

	public AnimationFrameInfo(string name, int startFrame, int endFrame, int frameCount, float speed)
	{
	}
}
