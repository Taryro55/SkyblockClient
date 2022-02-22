using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyblockClient.Options;

namespace SkyblockClient.Config
{
	[ModConfigWorker("minecraft")]
	class ModConfigWorkerMinecraft : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			string optionsFile = await helper.DownloadFileByte("minecraftoptions.txt");
			helper.Move(optionsFile, Path.Combine(Globals.skyblockRootLocation, "options.txt"));
		}
	}

	[ModConfigWorker("optifine")]
	class ModConfigWorkerOptifine : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			string optionsFile = await helper.DownloadFileByte("optifinetoptions.txt");
			helper.Move(optionsFile, Path.Combine(Globals.skyblockRootLocation, "optionsof.txt"));
		}
	}

	[ModConfigWorker("itlt")]
	class ModConfigWorkerITLT : ModConfigWorkerBase
	{
		public string configFolder => Path.Combine(Globals.skyblockConfigLocation, "itlt");

		public override async Task Work()
		{
			helper.InitFolders("config", "config/itlt");

			string sourceIcon = await helper.DownloadFileByte("icon.png");
			helper.Move(sourceIcon, Path.Combine(configFolder,"icon.png"));

			string sourceCfg = await helper.DownloadFileByte("itlt.cfg");
			helper.Move(sourceCfg, Path.Combine(Globals.skyblockConfigLocation, "itlt.cfg"));
		}
	}

	[ModConfigWorker("hytilities")]
	class ModConfigWorkerHytilities : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");

			string sourceCfg = await helper.DownloadFileByte("hytilities.toml");
			helper.Move(sourceCfg, Path.Combine(Globals.skyblockConfigLocation, "hytilities.toml"));
		}
	}

	[ModConfigWorker("cmm")]
	class ModConfigWorkerCmm : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config", "config/CustomMainMenu");

			string[] custommainmenu = new string[] { "mainmenu.json", "play.json" };
			foreach (var file in custommainmenu)
			{
				string source = await helper.DownloadFileByte(file);
				helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "CustomMainMenu", file));
			}
		}
	}

	[ModConfigWorker("sidebarmod")]
	class ModConfigWorkerSbm : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");
			string file = "SidebarMod.config";
			string source = await helper.DownloadFileByte(file);
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, file));
		}
	}

	[ModConfigWorker("neu")]
	class ModConfigWorkerNeu : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config", "config/notenoughupdates");
			string source = await helper.DownloadFileByte("neuconfig.json");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "notenoughupdates", "config.json"));
		}
	}

	[ModConfigWorker("apec")]
	class ModConfigWorkerApec : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config", "config/Apec");
			string source = await helper.DownloadFileByte("apecsettings.txt");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "Apec", "Settings.txt"));
		}
	}

	[ModConfigWorker("damagetint")]
	class ModConfigWorkerDamageTint : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("W-OVERFLOW", "W-OVERFLOW/DamageTint");
			string source = await helper.DownloadFileByte("damagetint.toml");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "DamageTint", "damagetint.toml"));
		}
	}

	[ModConfigWorker("patcher")]
	class ModConfigWorkerPatcher : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");
			string source = await helper.DownloadFileByte("patcher.toml");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "patcher.toml"));
		}
	}

	[ModConfigWorker("crashpatch")]
	class ModConfigWorkerCrashPatch : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("W-OVERFLOW", "W-OVERFLOW/CrashPatch");
			string source = await helper.DownloadFileByte("SKYCLIENT");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "CrashPatch", "SKYCLIENT"));
		}
	}

	[ModConfigWorker("hytilities-reborn")]
	class ModConfigWorkerHytilitiesReborn : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("W-OVERFLOW", "W-OVERFLOW/Hytilities Reborn");

			string source = await helper.DownloadFileByte("blockhighlight.toml");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "Hytilities Reborn", "blockhighlight.toml"));

			string sourceCfg = await helper.DownloadFileByte("hytilitiesreborn.toml");
			helper.Move(sourceCfg, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "Hytilities Reborn", "hytilitiesreborn.toml"));
		}
	}

	[ModConfigWorker("blockoverlay")]
	class ModConfigWorkerBlockOverlay : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");

			string source = await helper.DownloadFileByte("blockoverlay.cfg");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "blockoverlay.cfg"));
		}
	}

	[ModConfigWorker("nick_hider")]
	class ModConfigWorkerNickHider : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");

			string source = await helper.DownloadFileByte("nickhider.toml");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "nickhider.toml"));
		}
	}

	[ModConfigWorker("chatting")]
	class ModConfigWorkerChatting : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("W-OVERFLOW", "W-OVERFLOW/Chatting");

			string source = await helper.DownloadFileByte("chatshortcuts.json");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "Chatting", "chatshortcuts.json"));

			string sourceTabs = await helper.DownloadFileByte("chattabs.json");
			helper.Move(sourceTabs, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "Chatting", "chattabs.json"));

			string sourceCfg = await helper.DownloadFileByte("chatting.toml");
			helper.Move(sourceCfg, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "Chatting", "chatting.toml"));
		}
	}

	[ModConfigWorker("redaction")]
	class ModConfigWorkerRedaction : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("W-OVERFLOW", "W-OVERFLOW/REDACTION");

			string source = await helper.DownloadFileByte("redaction.toml");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "REDACTION", "redaction.toml"));
		}
	}

	[ModConfigWorker("keystrokes")]
	class ModConfigWorkerKeyStrokes : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");

			string source = await helper.DownloadFileByte("keystrokes.json");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "keystrokes.json"));
		}
	}

	[ModConfigWorker("levelhead")]
	class ModConfigWorkerLevelHead : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");

			string source = await helper.DownloadFileByte("levelhead.json");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "levelhead.json"));
		}
	}

	[ModConfigWorker("lobby_sounds")]
	class ModConfigWorkerLobbySounds : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("config");

			string source = await helper.DownloadFileByte("lobbysounds.toml");
			helper.Move(source, Path.Combine(Globals.skyblockConfigLocation, "lobbysounds.toml"));
		}
	}

	[ModConfigWorker("tabulous")]
	class ModConfigWorkerTabulous : ModConfigWorkerBase
	{
		public override async Task Work()
		{
			helper.InitFolders("W-OVERFLOW", "W-OVERFLOW/Tabulous");

			string source = await helper.DownloadFileByte("tabulous.toml");
			helper.Move(source, Path.Combine(Globals.skyblockRootLocation, "W-OVERFLOW", "Tabulous", "tabulous.toml"));
		}
	}
}
