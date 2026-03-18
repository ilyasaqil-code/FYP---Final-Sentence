using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class DialogFirstTalkWithYG : DialogTreeScript<DialogFirstTalkWithYG>
{
	public IEnumerator OnStart()
	{
		yield return C.Display("You walk over to the man sitting on the bench and begin talking to him");
		yield return C.You.WalkTo(Hotspot("Bench1").WalkToPoint);
		yield return C.You.Say("Hey there");
		yield return C.Barney.Say("Hey");
		yield return C.You.Say("I have questions");
		yield return C.Barney.Say("Everybody has questions in this place");
		yield return E.Break;
	}

	public IEnumerator OnStop()
	{
		yield return C.Barney.Say("Well, I think I've had enough of your questions");
		yield return C.You.Say("Thanks a bunch");
		yield return C.You.Say("I don't think I need anything else from you right now");
		yield return C.Barney.Say("There will come a point you do.");
		yield return C.Barney.Say("And when that happens, you know where to find me.");
		yield return C.Display("This is the end of today's demo. Thanks for playing!");
		yield return E.Break;
	}

	IEnumerator Option1( IDialogOption option )
	{
		yield return C.You.Say("You looked like you recognized me");
		yield return C.You.Say("You wouldn't happen to know who I am, would you?");
		yield return C.You.Say("I seem to have forgotten");
		yield return C.Barney.Say("Strange question you have there");
		yield return C.Barney.Say("Do you normally go up to people and ask them to help you figure out who you are?");
		yield return C.You.Say("It's my second time doing that, yeah");
		yield return C.You.Say("My first time was earlier today when I woke up in my cell");
		yield return C.Barney.Say("You're wrong");
		yield return C.You.Say("What?");
		yield return C.Barney.Say("You're wrong about me recognizing you. I don't.");
		yield return C.You.Say("Alright, well it was worth a shot.");
		D.FirstTalkWithYG.OptionOffForever(1);
		if (D.FirstTalkWithYG.NumOptionsEnabled == 0)
		{
		Stop();
		}
		yield return E.Break;
	}

	IEnumerator Option2( IDialogOption option )
	{
		yield return C.You.Say("What is this place?");
		yield return C.Barney.Say("It's a prison, in case you haven't noticed.");
		yield return C.You.Say("I know that, but what kind of prison is this? Where?");
		yield return C.Barney.Say("The maximum security kind");
		yield return C.Barney.Say("The kind you're not supposed to ever leave");
		yield return C.Barney.Say("Do you feel that breeze in the air?");
		yield return C.You.Say("Actually, yeah, I do");
		yield return C.You.Say("It's pretty refreshing actually");
		yield return C.Barney.Say("It's a sea breeze");
		yield return C.Barney.Say("Python Island is the most secure prison in the entire world");
		D.FirstTalkWithYG.OptionOffForever(2);
		if (D.FirstTalkWithYG.NumOptionsEnabled == 0)
		{
		Stop();
		}
		yield return E.Break;
	}

	IEnumerator Option3( IDialogOption option )
	{
		yield return C.You.Say("Who are you?");
		yield return C.Barney.Say("What do you mean by that question?");
		yield return C.You.Say("I mean, what's your name? What're you in for?");
		yield return C.Barney.Say("Well, if you mean it that way...");
		yield return C.Barney.Say("I'm just the guy in the yard");
		yield return C.Barney.Say("That's what everyone calls me");
		yield return C.Barney.Say("And what I'm in for is none of your business");
		D.FirstTalkWithYG.OptionOffForever(3);
		if (D.FirstTalkWithYG.NumOptionsEnabled == 0)
		{
		Stop();
		}
		yield return E.Break;
	}
}