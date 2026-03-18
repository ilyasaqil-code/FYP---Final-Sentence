using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class RoomYard : RoomScript<RoomYard>
{


	IEnumerator OnEnterRoomAfterFade()
	{
		C.You.SetPosition(Point("StartPos"));
		yield return E.Break;
	}

	void OnEnterRoom()
	{
	}

	IEnumerator OnLookAtHotspotClimbingFrame( IHotspot hotspot )
	{
		yield return C.You.Face(Hotspot("ClimbingFrame").LookAtPoint);
		yield return C.You.Say("I don't remember much, but I do remember that I can do a pull-up");
		yield return C.You.Say("If nothing else, I know where to show off my one talent");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotClimbingFrame( IHotspot hotspot )
	{
		yield return C.You.WalkTo(Hotspot("ClimbingFrame").WalkToPoint);
		yield return C.Display("You execute three perfect pull-ups in quick succession");
		yield return C.You.Say("My arms still work!");
		if (Hotspot("ClimbingFrame").UseCount == 0)
		{
		yield return C.You.Say("Hey, what's this?");
		yield return C.You.Say("Somebody left a barbell behind in the dirt");
		C.Player.AddInventory(I.Barbell, 1);
		}
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotFence1( IHotspot hotspot )
	{
		C.You.FaceBG(Hotspot("Fence1").LookAtPoint);
		yield return C.You.Say("I really don't want to try climbing that thing.");
		yield return C.You.Say("Razor wire hurts!");
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotFence1( IHotspot hotspot )
	{
		C.You.FaceBG(Hotspot("Fence1").LookAtPoint);
		yield return C.You.Say("I can see the cafeteria over there");
		yield return C.You.Say("Doesn't seem like it's mealtime yet.");
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotFence2( IHotspot hotspot )
	{
		C.You.FaceBG(Hotspot("Fence2").LookAtPoint);
		yield return C.You.Say("Behind that solid looking wall is the work areas");
		yield return C.You.Say("...how do I know that?");
		yield return E.Break;
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotFence2( IHotspot hotspot )
	{
		C.You.FaceBG(Hotspot("Fence2").LookAtPoint);
		yield return C.You.Say("I really don't want to try climbing that thing.");
		yield return C.You.Say("Razor wire hurts!");
		yield return E.Break;
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotCrowd1( IHotspot hotspot )
	{
		yield return C.Barney.Say("What are *you* looking at, tough guy??!");
		yield return E.WaitSkip();
		yield return C.You.FaceLeft();
		yield return E.WaitSkip();
		yield return C.You.FaceRight();
		yield return E.WaitSkip();
		yield return C.You.Say("Nothing! Carry on!");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotCrowd1( IHotspot hotspot )
	{
		yield return C.You.Say("No, I don't think I want to *interact* with that crowd");
		yield return C.You.Say("At least three of them might shiv me");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotCrowd2( IHotspot hotspot )
	{
		yield return C.You.WalkTo(Hotspot("Crowd2").WalkToPoint);
		yield return E.WaitSkip();
		yield return C.Barney.Say("...three macks for a lickback?");
		yield return C.Barney.Say("That price is bullshit. I got four for a kittle last week...");
		yield return C.You.FaceLeft();
		yield return E.WaitSkip();
		yield return C.You.FaceRight();
		yield return E.WaitSkip();
		yield return C.You.Say("Hey guys!");
		yield return C.You.Say("What are we talking about?");
		yield return E.WaitSkip(0.25f);
		yield return C.Barney.Say("...");
		yield return C.You.Say("Alright, tough crowd.");
		yield return C.You.WalkTo(Point("Walkaway"));
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotCrowd2( IHotspot hotspot )
	{
		yield return C.You.Face(Hotspot("Crowd2").LookAtPoint);
		yield return C.You.Say("Clearly, some kind of deal is going on");
		yield return C.You.Say("...and that definitely isn't just candy");
		yield return E.Break;
	}

	IEnumerator OnLookAtHotspotBench1( IHotspot hotspot )
	{
		yield return C.Display("Despite what it might look like, there's a singular person sitting on this bench");
		yield return C.Display("A lanky, shifty looking guy is trying his best to look at you while pretending to ignore you");
		yield return C.Display("(Just use your imagination for the visuals here)");
		yield return C.You.Say("Maybe I can go talk to that guy");
		yield return C.You.Say("He looks like he knows something I don't");
		yield return E.Break;
	}

	IEnumerator OnInteractHotspotBench1( IHotspot hotspot )
	{
		
		yield return C.You.Say("Hey there, stranger");
		yield return C.Barney.Say("...Hey there yourself, stranger");
		yield return C.Barney.Say("What brings you to my little corner of the yard?");
		D.FirstTalkWithYG.Start();
		yield return E.Break;
	}

	IEnumerator OnUseInvHotspotBench1( IHotspot hotspot, IInventory item )
	{

		yield return E.Break;
	}
}