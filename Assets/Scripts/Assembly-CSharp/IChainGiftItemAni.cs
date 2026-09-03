using System;
using UnityEngine;

public interface IChainGiftItemAni
{
	void DisAppear(Action callBack);

	void MoveNext(Vector3 pos, Action callBack);

	void Appear(Vector3 pos, Action callBack);
}
