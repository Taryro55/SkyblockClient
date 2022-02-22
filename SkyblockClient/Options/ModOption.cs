﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows;
using SkyblockClient.Options.Events;

namespace SkyblockClient.Options
{
	public class ModOption : Option, IEquatable<ModOption>, IEquatable<string>
	{
		public override IDownloadUrl DownloadUrl => Remote ? (IDownloadUrl)new RemoteDownloadUrl(Url) : new InternalDownloadUrl("mods/" + File);

		[JsonIgnore]
		public bool HasPackages => Utils.IsPropSet(Packages);
		public List<string> Packages { get; set; }

		public bool Config { get; set; }

		[JsonIgnore]
		public bool HasPacks => Utils.IsPropSet(Packs);	
		public List<string> Packs { get; set; }

		public override string ToString()
		{
			string result = $"{Id}-{Display}\n";
			result += $"\tfile: {File}\n";
			result += $"\tenabled: {Enabled}\n";
			result += $"\tdescription: {Description}\n";
			result += $"\tremote: {Remote}\n";
			result += $"\turl: {Url}\n";

			return result;
		}

		public bool Equals(string other)
		{
			return Id.Equals(other);
		}

		bool IEquatable<ModOption>.Equals(ModOption other)
		{
			return Id.Equals(other.Id);
		}

        public override void ComboBoxChecked(object sender, RoutedEventArgs e)
        {
            base.ComboBoxChecked(sender, e);

			if (HasPacks && Globals.Settings.enableModDependentPacksOnEnable)
			{
				foreach (var pack in Packs)
				{
					foreach (var packOption in Globals.packOptions)
					{
						if (packOption.Id == pack)
						{
							packOption.Enabled = Enabled;
						}
					}
				}
				Globals.CauseRefreshPacks();
			}
		}
		public override void CheckBox_HoverEnter(object sender, TextMouseEventArgs e)
		{
			Globals.MainWindow.ModDocument = e.OptionPreview;
		}

		public override void CheckBox_HoverLeave(object sender, TextMouseEventArgs e)
		{
			Globals.MainWindow.ModDocument = e.OptionPreview;
		}
	}
}
