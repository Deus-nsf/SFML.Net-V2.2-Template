using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using SFML.Window;
using SFML.Graphics;
using SFML.System;

/****************************************************************
File		:  SFMLConfig.cs
Author		:  Mehdi Alfiguigui
Last Update	:  29/06/2015
Role		:  Serves as config file for our window, loops, and threads.
******************************************************************/

namespace Template
{
	class SFMLConfig
	{
		public const int FrameratePerSecond = 60;
		public static int frameTimeMicro = (int)Math.Round(1000000 / (double)FrameratePerSecond);
		public static double aspectRatio;

		public static RenderWindow myWindow;
		public static Clock frameClock = new Clock();
		public static Thread renderingThread = new Thread(RenderingThread);
		public static EventWaitHandle eventsCompleted = new EventWaitHandle(false, EventResetMode.ManualReset);


		public static void MyConfig()
		{
			WindowConfig();
			myWindow.SetActive(false);
			Thread.CurrentThread.Priority = ThreadPriority.Highest;
			renderingThread.Start();

			//Screen myScreen = Screen.PrimaryScreen;

			while (myWindow.IsOpen)
			{
				if (frameClock.ElapsedTime.AsMicroseconds() >= frameTimeMicro)
				{
					myWindow.DispatchEvents();
					KeyboardEventHandler.KeyStateActions(myWindow);
					MouseEventHandler.MouseButtonStateActions(myWindow);
					eventsCompleted.Set(); // Disable lock on RenderingThread operations.
					frameClock.Restart();

					if (FrameratePerSecond <= 60)	// Considerably reduces CPU usage, but doesn't work well with high framerates (>60).
						Thread.Sleep(1);
				}
            }

			renderingThread.Abort();
        }


		public static void RenderingThread()
		{
			while (Thread.CurrentThread.IsAlive)
			{
				if (eventsCompleted.WaitOne(Timeout.Infinite))	// RenderingThread lock is here.
				{
					myWindow.Clear();
					GraphicsHandler.GraphicsHub(myWindow);
					myWindow.Display();
					eventsCompleted.Reset(); // Enable lock on RenderingThread operations.
				}
			}
		}


		public static void WindowConfig()
		{
			ContextSettings settings = new ContextSettings();
			settings.AntialiasingLevel = 4;

			myWindow = new RenderWindow(
				new VideoMode(1600, 900),
				"SFML Application (SFML.netV2.2 + Optimized Multithread)",
				Styles.Fullscreen,
				settings);

			aspectRatio = myWindow.Size.X / (double)myWindow.Size.Y;
			myWindow.SetVerticalSyncEnabled(true);
			myWindow.SetKeyRepeatEnabled(false);
			EventLinking(myWindow);
			MyShapes.SetShapes();
		}


		/// <summary>
		/// Linking all event methods to the current render window.
		/// </summary>
		/// <param name="myWindow"></param>
		public static void EventLinking(RenderWindow myWindow)
		{
			// Creating all events methods
			myWindow.Closed += new EventHandler(Events.OnClosed);
			myWindow.KeyPressed += new EventHandler<SFML.Window.KeyEventArgs>(Events.OnKeyPressed);
			myWindow.KeyReleased += new EventHandler<SFML.Window.KeyEventArgs>(Events.OnKeyReleased);
			myWindow.MouseButtonPressed += new EventHandler<MouseButtonEventArgs>(Events.OnMouseButtonPressed);
			myWindow.MouseButtonReleased += new EventHandler<MouseButtonEventArgs>(Events.OnMouseButtonReleased);
			myWindow.Resized += new EventHandler<SizeEventArgs>(Events.OnResize);
			myWindow.GainedFocus += new EventHandler(Events.OnFocusGained);
			myWindow.LostFocus += new EventHandler(Events.OnFocusLost);
			myWindow.TextEntered += new EventHandler<TextEventArgs>(Events.OnTextEntered);
			myWindow.MouseWheelMoved += new EventHandler<MouseWheelEventArgs>(Events.OnMouseWhellMoved);
			myWindow.MouseMoved += new EventHandler<MouseMoveEventArgs>(Events.OnMouseMoved);
			myWindow.MouseEntered += new EventHandler(Events.OnMouseEntered);
			myWindow.MouseLeft += new EventHandler(Events.OnMouseLeft);
		}
	}
}