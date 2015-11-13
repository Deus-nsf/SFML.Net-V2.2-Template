using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;
using SFML.Graphics;
using SFML.System;

/****************************************************************
File		:  KeyboardEventHandler.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Treats all actions related to keyboard states and events.
******************************************************************/

namespace Template
{
	class KeyboardEventHandler
	{
		//protected static bool isOk = false;
		protected static Vector2f vector = new Vector2f(0f, 0f);
		protected static int factor = 10;


		/// <summary>
		/// The list of actions performed for specific key states
		/// </summary>
		public static void KeyStateActions(RenderWindow window)
		{
			if (Keyboard.IsKeyPressed(Keyboard.Key.Right))
				vector.X += factor;
            if (Keyboard.IsKeyPressed(Keyboard.Key.Left))
				vector.X -= factor;
			if (Keyboard.IsKeyPressed(Keyboard.Key.Up))
				vector.Y -= factor;
			if (Keyboard.IsKeyPressed(Keyboard.Key.Down))
				vector.Y += factor;

			MyShapes.myCircle3.Position += vector;
			vector.X = 0f; vector.Y = 0f;
        }


		/// <summary>
		/// The list of actions performed for a key pressed
		/// </summary>
		public static void KeyPressedActions(RenderWindow window, KeyEventArgs keyPressed)
		{
			switch (keyPressed.Code)
			{
				case Keyboard.Key.Escape:
					window.Close();
					break;

				case Keyboard.Key.Delete:
					/*You can insert actions here for that particular case*/
					break;

				case Keyboard.Key.A:
					/*You can insert actions here for that particular case*/
					break;

				/*Etc...*/

				default:
					break;
			}
		}


		/// <summary>
		/// The list of actions performed for a key released
		/// </summary>
		public static void KeyReleasedActions(RenderWindow window, KeyEventArgs keyReleased)
		{
			switch (keyReleased.Code)
			{
				case Keyboard.Key.Delete:
					/*You can insert actions here for that particular case*/
					break;

				case Keyboard.Key.A:
					/*You can insert actions here for that particular case*/
					break;

				/*Etc...*/

				default:
					break;
			}
		}


		/// <summary>
		/// The list of actions performed for a character entered
		/// </summary>
		public static void TextEnteredActions(RenderWindow window, TextEventArgs charEntered)
		{
			char charValue = '\0'; char.TryParse(charEntered.Unicode, out charValue);

			// See the difference ? charValue is the character, not the key pressed.
			// For example here you can differentiate upper case with lower case :

			if ((charValue >= 'A') && (charValue <= 'Z'))
			{

			}
			if ((charValue >= 'a') && (charValue <= 'z'))
			{

			}

			switch (charValue)
			{
				case 'A':
					/*You can insert actions here for that particular case.*/
					break;

				case 'a':
					/*You can insert actions here for that particular case.*/
					break;

				/*Etc...*/

				default:
					break;
			}
		}
	}
}