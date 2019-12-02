using FightClub.Code;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
    public static class FightClubGame
    {
        public static IPowerUp PurchasePowerUp()
        {
            return new ClassImplementsIPowerUp();
        }

        public static IPotion PurchasePotion()
        {
            return new ClassImplementsIPotion();
        }

        public static IFighter HireFighter()
        {
            return new ClassImplementsIFighter();
        }
    }
}