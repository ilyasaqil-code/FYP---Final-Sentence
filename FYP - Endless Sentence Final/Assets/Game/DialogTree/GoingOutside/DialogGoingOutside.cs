using UnityEngine;
using System.Collections;
using PowerTools.Quest;
using PowerScript;
using static GlobalScript;

public class DialogGoingOutside : DialogTreeScript<DialogGoingOutside>
{
	public IEnumerator OnStart()
	{
		
		yield return E.Break;
	}

	public IEnumerator OnStop()
	{
		yield return E.Break;
	}
}