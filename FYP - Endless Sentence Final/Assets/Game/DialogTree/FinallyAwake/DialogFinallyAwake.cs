using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;


public class DialogFinallyAwake : DialogTreeScript<DialogFinallyAwake>
{
    
    public IEnumerator OnStart()
	{
		
		yield return E.Break;
	}

	public IEnumerator OnStop()
	{
		
		yield return E.Break;
	}

	IEnumerator Option1( IDialogOption option )
	{
		yield return C.You.Say("uhhh...");
		yield return C.Dave.Say("Careful now, slowly.");
		yield return C.Dave.Say("We wouldn't want you to hurt yourself");
		D.FinallyAwake.OptionOff(1, 2, 3);
		D.FinallyAwake.OptionOn(4, 5);
		yield return E.Break;
	}

	IEnumerator Option2( IDialogOption option )
	{
		yield return C.You.Say("ughh...");
		yield return C.Dave.Say("Careful now, speak slowly.");
		yield return C.Dave.Say("We wouldn't want you to hurt yourself");
		D.FinallyAwake.OptionOff(1, 2, 3);
		D.FinallyAwake.OptionOn(4, 5);
		yield return E.Break;
	}

	IEnumerator Option3( IDialogOption option )
	{
		yield return C.You.Say("hrkm...");
		yield return C.Dave.Say("Careful now, speak slowly.");
		yield return C.Dave.Say("We wouldn't want you to hurt yourself");
		D.FinallyAwake.OptionOff(1, 2, 3);
		D.FinallyAwake.OptionOn(4, 5);
		yield return E.Break;
	}

	IEnumerator Option4( IDialogOption option )
	{
		yield return C.You.Say("Where am I?");
		yield return C.Dave.Say("Right now? You're lying on the floor");
		yield return C.Dave.Say("I suppose you mean to ask 'what is this place' rather than 'what am I sitting on'?");
		D.FinallyAwake.OptionOff(4, 5, 6);
		D.FinallyAwake.OptionOn(7, 8);
		
		yield return E.Break;
	}

	IEnumerator Option7( IDialogOption option )
	{
		yield return C.You.Say("Yes, that first thing sounds right");
		yield return C.Dave.Say("In which case, I think maybe that last round of questions really was worse than usual");
		yield return C.Dave.Say("Seeing as you don't remember you're in prison.");
		D.FinallyAwake.OptionOn(5, 9);
		D.FinallyAwake.OptionOffForever(4, 7, 8);
		yield return E.Break;
	}

	IEnumerator Option9( IDialogOption option )
	{
		yield return C.You.Say("I'm in prison? Like actual prison?");
		yield return C.Dave.Say("Oh boy, here we go again");
		yield return C.Dave.Say("It'll be easier to just show you instead of trying to convince you again");
		yield return C.Dave.Say("Just open your eyes");
		yield return C.Display("At that moment, you realize you've been squeezing your eyelids shut the entire time.");
		yield return C.Display("You open them up and let in the painful light");
		Prop("Bg").Visible = true;
		C.You.Visible = true;
		C.Dave.Visible = true;
		
		yield return C.Dave.Say("Welcome to prison my friend!");
		yield return C.Dave.Say("Try not to touch anything too filthy");
		yield return C.Dave.Say("This is not your first day");
		
		Globals.interactCount = 0;
		Stop();
		yield return E.Break;
		
		
		
	}

	IEnumerator Option8( IDialogOption option )
	{
		yield return C.You.Say("No, that second thing sounds right");
		yield return C.Dave.Say("Phew, that's a relief");
		yield return C.Dave.Say("It's good you remember that you're in prison so I don't have to explain it again");
		D.FinallyAwake.OptionOn(5, 9);
		D.FinallyAwake.OptionOffForever(4, 7, 8);
		yield return E.Break;
	}

	IEnumerator Option5( IDialogOption option )
	{
		yield return C.You.Say("Who are you?");
		
		yield return C.Dave.Say("You really don't remember huh?");
		yield return C.Dave.Say("Well, it's pretty normal for you not to remember me after a round of questions");
		yield return C.Dave.Say("At least you're not asking me who *you* are");
		D.FinallyAwake.OptionOn(6);
		yield return E.Break;
	}

	IEnumerator Option6( IDialogOption option )
	{
		yield return C.You.Say("Wait, who am I?");
		
		yield return C.Dave.Say("Uh oh.");
		yield return C.Dave.Say("The head trauma this time is a lot worse than I expected.");
		yield return E.Break;
	}
}