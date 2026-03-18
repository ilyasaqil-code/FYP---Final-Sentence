using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class RoomCell : RoomScript<RoomCell>
{


	IEnumerator OnInteractHotspotDoor( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return C.WalkToClicked();
		yield return C.You.Say(" No getting out through here");
		yield return C.You.Say("Unless you happen to have the key...?");
		yield return C.Dave.Say(" I ain't that lucky");
		yield return C.Dave.Say(" Though I've never lost a game of cards");
		if (Hotspot("Door").FirstUse == true)
		{
		Globals.interactCount = Globals.interactCount + 1;
		}
		
		if (Globals.interactCount == 4)
		{
			yield return C.Display("Just as you're walking around your cell, a loud bell rings  outside");
			yield return C.You.Face(Hotspot("Door").LookAtPoint);
			yield return C.You.Say("What's that?");
			yield return C.Dave.Say("That would be the bell signaling yard time");
			yield return C.Dave.Say("Let's head out");
			E.ChangeRoomBG(R.Yard);
		}
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotDoor( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return C.You.Say(" Is that... a tower?");
		yield return C.You.Say(" I wonder what they can see");
		yield return C.Dave.Say("Everything");
		yield return C.Dave.Say("All the time.");
		yield return C.Dave.Say("...If they wanted to, at least");
		yield return E.Break;
	}

	void OnEnterRoom()
	{
		C.Dave.Room = R.Cell;
		C.Dave.SetPosition(373, -345);
	}

	IEnumerator OnEnterRoomAfterFade()
	{
		C.You.Visible = false;
		C.Dave.Visible = false;
		
		yield return C.Display("The first thing that comes back to you is your sense of hearing.");
		yield return C.Display("The darkness that clouds your mind is invaded by sounds.");
		yield return C.Display("The rhythm of dripping water. Distant footsteps. And a voice.");
		yield return C.Dave.Say("So, you're awake already?");
		yield return C.Dave.Say("I knew the latest round of questions couldn't keep you down");
		yield return C.Dave.Say("Nothing keeps you down for long");
		yield return C.Display("It takes you a while to find your own voice to reply");
		
		D.FinallyAwake.Start();
		
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotMirror( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return E.WaitSkip();
		yield return C.WalkToClicked();
		yield return C.Display(" You don't recognise the face staring back at you");
		yield return C.You.Say(" Why do I look so unfamiliar to myself?");
		yield return C.You.Say(" ...and where did all the stubble come from?");
		
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotMirror( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return C.WalkToClicked();
		yield return C.You.Say(" I wish I had a razor to shave.");
		yield return C.Dave.Say("The guy in the yard could help with that.");
		if (Hotspot("Mirror").FirstUse == true)
		{
		Globals.interactCount = Globals.interactCount + 1;
		}
		
		if (Globals.interactCount == 4)
		{
			yield return C.Display("Just as you're walking around your cell, a loud bell rings  outside");
			yield return C.You.Face(Hotspot("Door").LookAtPoint);
			yield return C.You.Say("What's that?");
			yield return C.Dave.Say("That would be the bell signaling yard time");
			yield return C.Dave.Say("Let's head out");
			E.ChangeRoomBG(R.Yard);
		}
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotToilet( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return C.You.Say(" Gross.");
		yield return C.You.Say("Is this thing ever cleaned?");
		yield return C.Dave.Say("Nah, you don't really need to clean toilets");
		yield return C.Dave.Say("That's what the flush is for");
		yield return C.You.Say("What? No, you definitely need to -");
		yield return C.You.Say("Nevermind.");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotToilet( IHotspot hotspot )
	{
		yield return C.WalkToClicked();
		yield return C.You.Say(" I don't need to go right now.");
		yield return C.You.Say(" Thankfully");
		if (Hotspot("Toilet").FirstUse == true)
		{
		Globals.interactCount = Globals.interactCount + 1;
		}
		
		if (Globals.interactCount == 4)
		{
			yield return C.Display("Just as you're walking around your cell, a loud bell rings  outside");
			yield return C.You.Face(Hotspot("Door").LookAtPoint);
			yield return C.You.Say("What's that?");
			yield return C.Dave.Say("That would be the bell signaling yard time");
			yield return C.Dave.Say("Let's head out");
			E.ChangeRoomBG(R.Yard);
		}
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotBeds( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return C.You.Say("Like the rest of this cell, absolutely filthy");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotBeds( IHotspot hotspot )
	{
		yield return C.You.Say("It's not night yet, I don't need to sleep");
		yield return C.Dave.Say("I don't sleep at all");
		yield return C.Dave.Say(" I just use mine for storing canned mackerel");
		if (Hotspot("Beds").FirstUse == true)
		{
		Globals.interactCount = Globals.interactCount + 1;
		yield return C.You.Say("Hey! There's a book underneath the sheets here");
		yield return C.You.Say("Can't hurt to pick it up");
		C.You.AddInventory(I.Book, 1);
		}
		
		if (Globals.interactCount == 4)
		{
			yield return C.Display("Just as you're walking around your cell, a loud bell rings  outside");
			yield return C.You.Face(Hotspot("Door").LookAtPoint);
			yield return C.You.Say("What's that?");
			yield return C.Dave.Say("That would be the bell signaling yard time");
			yield return C.Dave.Say("Let's head out");
			E.ChangeRoomBG(R.Yard);
		}
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotExit( IHotspot hotspot )
	{
		yield return C.FaceClicked();
		yield return C.You.Say("Normally it's a bit more complicated to leave this place");
		yield return C.You.Say("But today, we get to see outside");
		yield return C.You.Say("Just left click when you're ready");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotExit( IHotspot hotspot )
	{
		yield return C.WalkToClicked();
		yield return C.You.Say(" Well, this is it");
		yield return C.You.Say("Time to see the great outdoors");
		yield return C.Dave.Say("It's just the yard man, no need to wax poetic");
		yield return E.WaitSkip();
		yield return C.You.Say("Well, here goes");
		yield return C.Plr.ChangeRoom(R.Yard);
		yield return E.Break;
	}

	IEnumerator OnLookAtPropCiggies( IProp prop )
	{
		yield return C.FaceClicked();
		yield return C.You.Say(" Wait, who left this pack of cigarettes here?");
		yield return C.Dave.Say("Beats me.");
		yield return C.Dave.Say("I'm a non smoker.");
		yield return E.Break;
	}

	IEnumerator OnInteractPropCiggies( IProp prop )
	{
		yield return C.WalkToClicked();
		yield return C.Display("You put the pack of cigarettes in your pocket");
		yield return C.You.Say("Who knows, might come in handy");
		I.Ciggies.Add(1);
		Prop("Ciggies").Hide();
		yield return E.Break;
	}
}