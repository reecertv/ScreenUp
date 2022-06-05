using DiscordRPC;
using DiscordRPC.Logging;
using System;

namespace ScreenUp
{
	public partial class DiscordRPC
	{
		public static DiscordRpcClient client;

		public static void Initialize()
		{
			/*
			Create a Discord client
			NOTE: 	If you are using Unity3D, you must use the full constructor and define
					 the pipe connection.
			*/
			client = new DiscordRpcClient("982655004953419877");

			//Set the logger
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			//Subscribe to events
			client.OnReady += (sender, e) =>
			{
				Console.WriteLine("Received Ready from user {0}", e.User.Username);
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				Console.WriteLine("Received Update! {0}", e.Presence);
			};

			//Connect to the RPC
			client.Initialize();

			//Set the rich presence
			//Call this as many times as you want and anywhere in your code.
			client.SetPresence(new RichPresence()
			{
				Details = "",
				State = "Viewing",
				Assets = new Assets()
				{
					LargeImageKey = "htp512w",
					LargeImageText = "Can you hack the Password?",
					SmallImageKey = "image_small"
				},
				Timestamps = Timestamps.Now,
			});
		}

		public static void Deinitialize()
		{
			client.Dispose();
		}


	}
}