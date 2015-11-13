using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;
using SFML.Graphics;
using SFML.System;

/****************************************************************
File		:  MouseEventHandler.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Treats all actions related to mouse events and states.
******************************************************************/

namespace Template
{
	class MouseEventHandler
	{
		protected static uint factor = 10;
		protected static Vector2u vectorInc = new Vector2u((uint)Math.Round(SFMLConfig.aspectRatio * factor), factor);
		protected static Vector2u vector = new Vector2u(0, 0);
		

		/// <summary>
		/// The list of actions performed for specific mouse button states.
		/// </summary>
		public static void MouseButtonStateActions(RenderWindow window)
		{
			// here we can resize the window while maintaining original aspect ratio

			/*if (Mouse.IsButtonPressed(Mouse.Button.Left) || Mouse.IsButtonPressed(Mouse.Button.Right))
			{
				if (Mouse.IsButtonPressed(Mouse.Button.Left))
					vector += vectorInc;
				if (Mouse.IsButtonPressed(Mouse.Button.Right))
				{
					if (window.Size.Y > (240))
						vector -= vectorInc;
				}

				window.Size += vector;
				vector.X = 0; vector.Y = 0;
			}*/
		}


		/// <summary>
		/// The list of actions performed for a mouse button pressed.
		/// </summary>
		public static void MouseButtonPressedActions(RenderWindow window, MouseButtonEventArgs mouseButtonPressed)
		{
			switch (mouseButtonPressed.Button)
			{
				case Mouse.Button.Left:
					/*You can insert actions here*/
					break;

				case Mouse.Button.Right:
					/*You can insert actions here*/
					break;

				case Mouse.Button.Middle:
					/*You can insert actions here*/
					break;

				/*Etc...*/

				default:
					break;
			}
		}


		/// <summary>
		/// The list of actions performed for a mouse button released.
		/// </summary>
		public static void MouseButtonReleasedActions(RenderWindow window, MouseButtonEventArgs mouseButtonReleased)
		{
			switch (mouseButtonReleased.Button)
			{
				case Mouse.Button.Left:
					/*You can insert actions here*/
					break;

				case Mouse.Button.Right:
					/*You can insert actions here*/
					break;

				case Mouse.Button.Middle:
					/*You can insert actions here*/
					break;

				/*Etc...*/

				default:
					break;
			}
		}

		/// <summary>
		/// The list of actions performed when the mouse wheel moved.
		/// </summary>
		public static void MouseWheelMovedActions(RenderWindow window, MouseWheelEventArgs mouseWheelMoved)
		{
			if (mouseWheelMoved.Delta == +1)
			{

			}
			else if(mouseWheelMoved.Delta == -1)
			{

			}
		}
    }
}
