using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;
using SFML.Graphics;

/****************************************************************
File		:  Events.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Treats all events of the current window.
******************************************************************/

namespace Template
{
	class Events
	{
		/// <summary>
		/// Function called when a key is pressed.
		/// </summary>
		public static void OnKeyPressed(object sender, KeyEventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			KeyboardEventHandler.KeyPressedActions(window, e);
		}

		/// <summary>
		/// Function called when a key is released.
		/// </summary>
		public static void OnKeyReleased(object sender, KeyEventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			KeyboardEventHandler.KeyReleasedActions(window, e);
		}

		/// <summary>
		/// Function called when a character/text is entered.
		/// </summary>
		public static void OnTextEntered(object sender, TextEventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			KeyboardEventHandler.TextEnteredActions(window, e);
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Function called when a mouse button is pressed.
		/// </summary>
		public static void OnMouseButtonPressed(object sender, MouseButtonEventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			MouseEventHandler.MouseButtonPressedActions(window, e);
		}

		/// <summary>
		/// Function called when a mouse button is released.
		/// </summary>
		public static void OnMouseButtonReleased(object sender, MouseButtonEventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			MouseEventHandler.MouseButtonReleasedActions(window, e);
		}

		/// <summary>
		/// Function called when the mouse wheel moved.
		/// </summary>
		public static void OnMouseWhellMoved(object sender, MouseWheelEventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			MouseEventHandler.MouseWheelMovedActions(window, e);
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////

		/// <summary>
		/// Function called when the red cross of the application is hit.
		/// </summary>
		public static void OnClosed(object sender, EventArgs e)
		{
			RenderWindow window = (RenderWindow)sender;
			window.Close();
		}

		/// <summary>
		/// Function called when the window is resized.
		/// </summary>
		public static void OnResize(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Function called when the window focus is gained.
		/// </summary>
		public static void OnFocusGained(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Function called when the window focus is lost.
		/// </summary>
		public static void OnFocusLost(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Function called when the mouse cursor moved.
		/// </summary>
		public static void OnMouseMoved(object sender, MouseMoveEventArgs e)
		{

		}
		/// <summary>
		/// Function called when the mouse enters the window.
		/// </summary>
		public static void OnMouseEntered(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Function called when the mouse leaves the window.
		/// </summary>
		public static void OnMouseLeft(object sender, EventArgs e)
		{

		}
	}
}
