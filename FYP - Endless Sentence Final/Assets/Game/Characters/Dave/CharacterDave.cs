using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class CharacterDave : CharacterScript<CharacterDave>
{


	IEnumerator OnInteract()
	{
		yield return C.You.Face(C.Dave);
		yield return C.You.Say("Hey, got any tips for surviving this place?");
		yield return C.You.Say("Seeing as how I don't remember anything");
		yield return C.Dave.Say("Hmmm, lets see...");
		yield return E.WaitSkip();
		yield return C.Dave.Say("Don't piss anybody off");
		yield return C.Dave.Say("Don't eat the porridge on Wednesdays");
		yield return C.Dave.Say("And most importantly");
		yield return C.Dave.Say("Don't try to remember anything too hard");
		yield return C.You.Say("What?");
		yield return C.Dave.Say("Like I said, don't try to remember too hard");
		yield return C.You.Say("I'll keep that in mind... or not.");
		yield return E.Break;
	}

	IEnumerator OnLookAt()
	{
		yield return C.You.Say(" Yep, he's my cell mate alright");
		yield return C.You.Say(" Definitely seems very familiar");
		yield return C.You.Say(" Although from where exactly, I can't say");
		yield return C.Dave.Say(" Are you done looking?");
		yield return C.Dave.Say(" And speaking out loud?");
		yield return C.You.Say(" Sorry.");
		yield return E.Break;
	}

	IEnumerator OnUseInv( IInventory item )
	{

		yield return E.Break;
	}
}