using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamageCalc
{
    public class SwordDamage
    {
        public SwordDamage(int startingRoll)
        {
            Roll = startingRoll;
            CalculateDamage();
        }

        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
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
            decimal magicMultipier = 1M;
            if (Magic) magicMultipier = 1.75M;
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultipier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
            //Debug.WriteLine($"CalculateDamage finished: {Damage} (roll: {Roll})");
        }

    }
}
