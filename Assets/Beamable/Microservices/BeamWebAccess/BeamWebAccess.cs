using System;
using System.Collections.Generic;
using Beamable.Common;
using Beamable.Server;
using UnityEngine;

namespace Beamable.Microservices
{
	[Microservice("BeamWebAccess")]
	public class BeamWebAccess : Microservice
	{
		private const string DICE_ROLLED_STAT = "DICE_ROLLED";
		private System.Random _random = new System.Random();

		[ClientCallable]
		public async void RollDice()
		{
			Debug.Log($"Rolling dice for {Context.UserId}.");
			var d1 = _random.Next(6) + 1;
			var d2 = _random.Next(6) + 1;
			string diceRollStatValue = $"{d1},{d2}";
			var statsToSet = new Dictionary<string, string>()
			{
				[DICE_ROLLED_STAT] = diceRollStatValue
			};
			await Services.Stats.SetProtectedPlayerStats(Context.UserId, statsToSet);
			Debug.Log($"Saved dice roll '{diceRollStatValue}' for {Context.UserId}");
		}

		[ClientCallable]
		public async Promise<string> CheckDiceRolled()
		{
			Debug.Log($"Checking dice for {Context.UserId}");
			try
			{
				var dice = await Services.Stats.GetProtectedPlayerStat(Context.UserId, DICE_ROLLED_STAT);
				Debug.Log($"Found dice '{dice}' for {Context.UserId}");
				return dice;
			}
			catch (Exception e)
			{
				return $"ERROR: {e.Message}";
			}
		}
	}
}
