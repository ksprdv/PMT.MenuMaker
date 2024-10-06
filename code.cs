//  Author: Peek-A-Boo
// Project: PMT.MenuMaker
// Version: 1.0 public

//Code for Start/Awake method:

	MakeGUI.PreInit();
	SetGUI.openString = "Cheat";
	SetGUI.closeString = "Close";
	SetGUI.labels = new string[]
	{
		"Toggle I",
		"Toggle II",
		"Toggle III",
		"Toggle IV",
		"Toggle V"
	};
	SetGUI.creditString = "Modded by Name";
	SetGUI.menuXPos = -1f;
	SetGUI.menuYPos = -1f;
	SetGUI.openXPos = -1f;
	SetGUI.openYPos = -1f;
	SetGUI.closeXPos = -1f;
	SetGUI.closeYPos = -1f;
	SetGUI.hasMargin = true;
	SetGUI.buttonSize = 50;
	SetGUI.menuAlpha = 1f;
	SetGUI.menuStyle = 0;
	MakeGUI.Init();

//Code for OnGUI method:

	MakeGUI.OnGUI();