
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class chara
    {
        public int Damage = 8;
        public int HP = 40;
        public void Attack(chara enemy)
        {
            if (this.Damage < 0)
            {
                this.Damage = 1;
            }
            enemy.HP -= this.Damage;
        }
        public void Heal(chara chara)
        {
            this.HP += 5;
            if (this.HP > 40)
            {
                this.HP = 40;
            }
        }

        public void weaken(chara enemy)
        {
            enemy.Damage -= 1;
        }

        public void Strength(chara chara)
        {
            this.Damage += 3;
        }
    }

}