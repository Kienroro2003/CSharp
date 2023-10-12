﻿using System;
namespace SwordDamageBlazor
{
	public class SwordDamage
	{
		public const int BASE_DAMAGE = 3;
		public const int FLAME_DAMAGE = 2;

		public int Roll;
		public decimal MagicMultiplier = 1M;
		public int FlamingDamge = 0;
		public int Damage;

		public void CalculateDamage()
		{
			Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamge;
		}

		public void SetMagic(bool isMagic)
		{
			if (isMagic)
			{
				MagicMultiplier = 1.75M;
			}
			else
			{
				MagicMultiplier = 1M;
			}
			CalculateDamage();
		}

		public void SetFlamimg(bool isFlaming)
		{
			CalculateDamage();
			if (isFlaming)
			{
				Damage += FLAME_DAMAGE;
			}
		}
	}
}

