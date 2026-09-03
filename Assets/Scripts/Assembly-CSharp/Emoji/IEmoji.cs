namespace Emoji
{
	public interface IEmoji
	{
		EntityBase entity { get; }

		void SetEntity(EntityBase owner);

		void PlayIndex(int pIndex);
	}
}
