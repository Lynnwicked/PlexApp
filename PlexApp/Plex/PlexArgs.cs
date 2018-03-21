﻿using PowerArgs;

namespace PlexApp.Plex {
  public class PlexArgs {
    [ArgShortcut("source"), ArgShortcut(ArgShortcutPolicy.ShortcutsOnly), ArgRequired, ArgDescription("Path of source folder"), ArgPosition(1)]
    public string Source { get; set; }
    
    [ArgShortcut("target"), ArgShortcut(ArgShortcutPolicy.ShortcutsOnly), ArgRequired, ArgDescription("Path of target folder"), ArgPosition(2)]
    public string Target { get; set; }
    
    [ArgShortcut("log"), ArgShortcut(ArgShortcutPolicy.ShortcutsOnly), ArgRequired, ArgDescription("Path of log file"), ArgPosition(3)]
    public string Log { get; set; }
  }
}