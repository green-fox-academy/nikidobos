using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    abstract class Aircraft
    {
        int maxAmmo;
        int baseDamage;
        int baseAmmo;
        int damage;

        public Aircraft(int maxAmmo, int baseDamage, int baseAmmo)
        {
            this.maxAmmo = maxAmmo;
            this.baseDamage = baseDamage;
            this.baseAmmo = baseAmmo;
        }

        public Aircraft()
        {

        }

        public int MaxAmmo
        {
            get
            {
                return maxAmmo;
            }
        }

        public int BaseDamage
        {
            get
            {
                return baseDamage;
            }
        }

        public int Fight()
        {
            for (int i = 0; i < maxAmmo; i++)
            {
                maxAmmo--;
            }
            damage = baseDamage * maxAmmo;
            return damage;
        }

        public virtual int Refill(int number)
        {
            int missingAmmo = maxAmmo - baseAmmo;
            if (number > missingAmmo)
            {
                baseAmmo = maxAmmo;
                return number - missingAmmo;
            }
            else
            {
                baseAmmo += number;
                return 0;
            }
        }
        public abstract string GettingType();

        public abstract bool IsPriority();

        public string GetStatus()
        {
            return String.Format(GettingType() + ", " + "Ammo: " + baseAmmo + ", Base Damage: " + BaseDamage + ", All damage: " + damage);
        }
    }
}

