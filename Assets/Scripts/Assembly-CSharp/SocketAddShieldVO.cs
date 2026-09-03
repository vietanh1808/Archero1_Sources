using System;

[Serializable]
public class SocketAddShieldVO : CustomJsonActionVO
{
	public int skillAloneId;

	public float radius;

	public float rotateSpeed;

	public float hpRatio;

	public SocketAddShieldVO(string action, in int _skillAloneId, in float _radius, in float _rotateSpeed, in float _hpRatio)
	{
	}
}
