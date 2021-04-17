namespace UnityEngine
{

	public class Behaviour : Component
	{
		public Behaviour() {
			enabled = true;

		}

		
		public bool enabled { get; set; }
		
		public bool isActiveAndEnabled { get => _gameObject.activeInHierarchy && enabled; }
	}
}