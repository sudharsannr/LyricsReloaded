﻿/*
    Copyright 2013 Phillip Schichtel

    This file is part of LyricsReloaded.

    LyricsReloaded is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LyricsReloaded is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with LyricsReloaded. If not, see <http://www.gnu.org/licenses/>.

*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CubeIsland.LyricsReloaded;
using CubeIsland.LyricsReloaded.Provider;

namespace LyricsUnitTests
{
    public class LyricsTests
    {
        private static LyricsReloaded lr = null;

        public static LyricsReloaded getLyricsReloaded()
        {
            if (lr == null)
            {
                lr = new LyricsReloaded(".");
                lr.loadConfigurations();
            }
            return lr;
        }

        public static Provider getProvider(string name)
        {
            Provider p = getLyricsReloaded().getProviderManager().getProvider(name);
            Assert.IsNotNull(p, "Provider '" + name + "' not found!");
            return p;
        }
    }
}
