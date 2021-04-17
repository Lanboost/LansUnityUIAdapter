#region Assembly UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// C:\Program Files\Unity\Hub\Editor\2019.4.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll
#endregion

namespace UnityEngine
{
	//
	// Summary:
	//     Types of UnityGUI input and processing events.
	public enum EventType
	{
		//
		// Summary:
		//     Mouse button was pressed.
		MouseDown = 0,
		//
		// Summary:
		//     An event that is called when the mouse is clicked.
		mouseDown = 0,
		//
		// Summary:
		//     Mouse button was released.
		MouseUp = 1,
		//
		// Summary:
		//     An event that is called when the mouse is no longer being clicked.
		mouseUp = 1,
		//
		// Summary:
		//     Mouse was moved (Editor views only).
		MouseMove = 2,
		mouseMove = 2,
		//
		// Summary:
		//     Mouse was dragged.
		MouseDrag = 3,
		//
		// Summary:
		//     An event that is called when the mouse is clicked and dragged.
		mouseDrag = 3,
		//
		// Summary:
		//     A keyboard key was pressed.
		KeyDown = 4,
		keyDown = 4,
		//
		// Summary:
		//     A keyboard key was released.
		KeyUp = 5,
		keyUp = 5,
		//
		// Summary:
		//     The scroll wheel was moved.
		ScrollWheel = 6,
		scrollWheel = 6,
		//
		// Summary:
		//     A repaint event. One is sent every frame.
		Repaint = 7,
		repaint = 7,
		//
		// Summary:
		//     A layout event.
		Layout = 8,
		layout = 8,
		//
		// Summary:
		//     Editor only: drag & drop operation updated.
		DragUpdated = 9,
		dragUpdated = 9,
		//
		// Summary:
		//     Editor only: drag & drop operation performed.
		DragPerform = 10,
		dragPerform = 10,
		//
		// Summary:
		//     Event should be ignored.
		Ignore = 11,
		ignore = 11,
		//
		// Summary:
		//     Already processed event.
		Used = 12,
		used = 12,
		//
		// Summary:
		//     Validates a special command (e.g. copy & paste).
		ValidateCommand = 13,
		//
		// Summary:
		//     Execute a special command (eg. copy & paste).
		ExecuteCommand = 14,
		//
		// Summary:
		//     Editor only: drag & drop operation exited.
		DragExited = 15,
		//
		// Summary:
		//     User has right-clicked (or control-clicked on the mac).
		ContextClick = 16,
		//
		// Summary:
		//     Mouse entered a window (Editor views only).
		MouseEnterWindow = 20,
		//
		// Summary:
		//     Mouse left a window (Editor views only).
		MouseLeaveWindow = 21
	}
}