﻿using System;
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

}
