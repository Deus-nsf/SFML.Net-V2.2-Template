using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;
using SFML.Graphics;
using SFML.System;

/****************************************************************
File		:  MyShapes.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Handle the shapes creation and settings.
******************************************************************/

namespace Template
{
	class MyShapes
	{
		public static CircleShape myCircle = new CircleShape(50);
		public static CircleShape myCircle2 = new CircleShape(50);
		public static CircleShape myCircle3 = new CircleShape(200, 100);

		public static void SetShapes()
		{
			myCircle.FillColor = Color.Red;
			myCircle2.FillColor = Color.Cyan;
			myCircle3.FillColor = Color.Yellow;

			myCircle.Position = new Vector2f(50, 50);
			myCircle2.Position = new Vector2f(150, 150);
			myCircle3.Position = new Vector2f(250, 250);
		}
	}
}