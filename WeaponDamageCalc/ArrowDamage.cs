using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The base damage for and arrow is 
 * 1D6 roll multiplied by 2.5HP
 * a flaming arrow adds an extra 1.25HP
 * the result is rounded UP to the neares integer HP
 */
namespace WeaponDamageCalc
{
    public class ArrowDamage
    {
        public ArrowDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        private const decimal BASE_MULTIPIER = .35M;
        private const decimal MAGIC_MULTIPIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;
        private int roll;
        private bool flaming;
        private bool magic;

        public int Roll
        {
            get { return roll; }
            set { roll = value; }
        }
        public bool Flaming
        {
            get { return flaming; }
            set { flaming = value; CalculateDamage(); }
        }
        public bool Magic
        {
            get { return magic; }
            set { magic = value; CalculateDamage(); }
        }
        public int Damage { get; private set; }
        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPIER;
            if (Magic) baseDamage *= MAGIC_MULTIPIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage += FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
