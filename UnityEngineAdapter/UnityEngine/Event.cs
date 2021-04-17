#region Assembly UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

using System;
using System.ComponentModel;

namespace UnityEngine
{
	public sealed class Event
	{
		public Event() { throw new System.NotImplementedException(); }
		public Event(int displayIndex) { throw new System.NotImplementedException(); }
		public Event(Event other) { throw new System.NotImplementedException(); }

		~Event() { throw new System.NotImplementedException(); }

		//
		// Summary:
		//     The current event that's being processed right now.
		public static Event current { get; set; }
		//
		// Summary:
		//     How hard stylus pressure is applied.

		public float pressure { get; set; }
		//
		// Summary:
		//     Index of display that the event belongs to.

		public int displayIndex { get; set; }
		//
		// Summary:
		//     The type of event.
		public EventType type { get; set; }
		//
		// Summary:
		//     The name of an ExecuteCommand or ValidateCommand Event.
		public string commandName { get; set; }
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", true)]
		public Ray mouseRay { get; set; }
		//
		// Summary:
		//     Is Shift held down? (Read Only)
		public bool shift { get; set; }
		//
		// Summary:
		//     Is Control key held down? (Read Only)
		public bool control { get; set; }
		//
		// Summary:
		//     Is Caps Lock on? (Read Only)
		public bool capsLock { get; set; }
		//
		// Summary:
		//     Is Command/Windows key held down? (Read Only)
		public bool command { get; set; }
		//
		// Summary:
		//     The raw key code for keyboard events.

		public KeyCode keyCode { get; set; }
		//
		// Summary:
		//     Is the current keypress on the numeric keyboard? (Read Only)
		public bool numeric { get; set; }
		//
		// Summary:
		//     Is the current keypress a function key? (Read Only)
		public bool functionKey { get; }
		//
		// Summary:
		//     Is this event a keyboard event? (Read Only)
		public bool isKey { get; }
		//
		// Summary:
		//     Is Alt/Option key held down? (Read Only)
		public bool alt { get; set; }
		//
		// Summary:
		//     The character typed.

		public char character { get; set; }
		public bool isScrollWheel { get; }
		//
		// Summary:
		//     Is this event a mouse event? (Read Only)
		public bool isMouse { get; }
		//
		// Summary:
		//     Which modifier keys are held down.

		public EventModifiers modifiers { get; set; }
		//
		// Summary:
		//     Which mouse button was pressed.

		public int button { get; set; }
		//
		// Summary:
		//     The type of pointer that created this event (for example, mouse, touch screen,
		//     pen).

		//public PointerType pointerType { get; set; }
		//
		// Summary:
		//     The relative movement of the mouse compared to last event.

		public Vector2 delta { get; set; }
		//
		// Summary:
		//     The mouse position.

		public Vector2 mousePosition { get; set; }

		public EventType rawType { get; }
		//
		// Summary:
		//     How many consecutive mouse clicks have we received.
		public int clickCount { get; set; }

		//
		// Summary:
		//     Returns the current number of events that are stored in the event queue.
		//
		// Returns:
		//     Current number of events currently in the event queue.
		public static int GetEventCount() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Create a keyboard event.
		//
		// Parameters:
		//   key:
		public static Event KeyboardEvent(string key) { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get the next queued [Event] from the event system.
		//
		// Parameters:
		//   outEvent:
		//     Next Event.
		public static bool PopEvent(Event outEvent) { throw new System.NotImplementedException(); }
		public override bool Equals(object obj) { throw new System.NotImplementedException(); }
		public override int GetHashCode() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Get a filtered event type for a given control ID.
		//
		// Parameters:
		//   controlID:
		//     The ID of the control you are querying from.
		
		public EventType GetTypeForControl(int controlID) { throw new System.NotImplementedException(); }
		public override string ToString() { throw new System.NotImplementedException(); }
		//
		// Summary:
		//     Use this event.
		public void Use() { throw new System.NotImplementedException(); }
	}
}