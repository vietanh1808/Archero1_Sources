using System.Collections.Generic;

public interface IAct5thHuntingArrow : IAct5thHuntingEntity
{
	float GetWidth();

	float GetLength();

	HashSet<int> HaveMarkEnemy();
}
