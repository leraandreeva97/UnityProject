using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Collectable {
	protected override void OnRabitHit (HeroRabit rabit)
	{
		if (rabit.IsGrow()) {
			rabit.ScaleDown ();
			this.CollectedHide ();
		} else {
			this.CollectedHide ();
			rabit.death ();
		}
	}
}

