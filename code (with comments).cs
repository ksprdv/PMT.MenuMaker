//  Author: Peek-A-Boo
// Project: PMT.MenuMaker
// Version: 1.0 public

//Code for Start/Awake method:

	MakeGUI.PreInit();
	SetGUI.openString = "Cheat";				//text for the opening button, which can be dragged around
	SetGUI.closeString = "Close";				//text for the closing button, if short will be placed differently
	SetGUI.labels = new string[]				//labels for the buttons; can be as many as needed
	{
		"Toggle I",
		"Toggle II",
		"Toggle III",
		"Toggle IV",
		"Toggle V"
	};
	SetGUI.creditString = "Modded by Name";		//credits line at the bottom of the menu
	SetGUI.menuXPos = -1f;						//X position of the menu, all positions are calculated from the top-left corner
	SetGUI.menuYPos = -1f;						//Y position of the menu, suggested value: 45
	SetGUI.openXPos = -1f;						//X position of the opening button
	SetGUI.openYPos = -1f;						//Y position of the opening button
	SetGUI.closeXPos = -1f;						//Y position of the closing button, suggested value: -1
	SetGUI.closeYPos = -1f;						//X position of the closing button, suggested value: -1
	SetGUI.hasMargin = true;					//margins around the buttons, suggested value: true
	SetGUI.buttonSize = 50;						//max size of the buttons, from 40 to 60
	SetGUI.menuAlpha = 1f;						//transparency of the menu, from 0.5f to 1f
	SetGUI.menuStyle = 0;						//style of the menu, from 0 to 3
	MakeGUI.Init();

//Code for OnGUI method:

	MakeGUI.OnGUI();