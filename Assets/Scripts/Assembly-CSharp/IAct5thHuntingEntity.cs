using UnityEngine;

public interface IAct5thHuntingEntity
{
	float GetCollideDmg();

	bool GetAllowStatus(Act5thHuntingEntityStatus status);

	bool HaveData();

	GameObject GetEntity();

	Act5thHuntingEntityType GetEntityType();

	Vector2 GetAnchoredPos();

	void OnCollideEntity(int triggerHashCode, float dmg);

	bool OnCollideWall(Vector2 wallVerticalDir);

	void OnMove(float deltaTime);

	void OnRecycle();

	void OnRecycleImmediately();

	void OnClearData();
}
