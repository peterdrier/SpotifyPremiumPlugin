﻿// Copyright(c) Loupedeck.All rights reserved.

namespace Loupedeck.Plugins.SpotifyPremium.Commands.Volume
{
    internal class UnmuteCommand : SpotifyCommand
    {
        public UnmuteCommand() : base("Unmute", "Unmute description", "Spotify Volume") { }

        protected override void RunCommand(string actionParameter)
        {
            Wrapper.Unmute();
        }

        protected override string IconResource => "Loupedeck.SpotifyPremiumPlugin.Icons.Width80.Volume.png";
    }
}