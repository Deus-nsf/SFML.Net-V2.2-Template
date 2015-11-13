using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;
using SFML.Window;
using SFML.System;

/****************************************************************
File		:  GraphicsHandler.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Handle the draw calls.
******************************************************************/

namespace Template
{
	class GraphicsHandler
	{
		public static void GraphicsHub(RenderWindow window)
		{
            window.Draw(MyShapes.myCircle);
			window.Draw(MyShapes.myCircle2);
			window.Draw(MyShapes.myCircle3);
        }
	}
}