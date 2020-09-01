
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            chara charaInstance = new chara();
            chara enemyInstance = new chara();

            Console.WriteLine("Q = 攻撃, W = 回復, E = 敵の攻撃力を減らす, R = 自分の攻撃力を強化");

            while (charaInstance.HP > 0 && enemyInstance.HP > 0)
            {
                char atk = (char)Console.Read();

                if (atk == 'Q' || atk == 'q')
                {
                    charaInstance.Attack(enemyInstance);
                    Random enemyatk = new Random();
                    if (enemyatk.Next(0, 3) == 0)
                    {
                        enemyInstance.Attack(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 1)
                    {
                        enemyInstance.Heal(enemyInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 2)
                    {
                        enemyInstance.weaken(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 3)
                    {
                        enemyInstance.Strength(charaInstance);
                    }

                    Console.WriteLine("君のHP = " + charaInstance.HP + " 攻撃力 = " + charaInstance.Damage);
                    Console.WriteLine("敵のHP = " + enemyInstance.HP + " 攻撃力 = " + enemyInstance.Damage + "\n");

                }
                else if (atk == 'W' || atk == 'w')
                {
                    charaInstance.Heal(charaInstance);
                    Random enemyatk = new Random();
                    if (enemyatk.Next(0, 3) == 0)
                    {
                        enemyInstance.Attack(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 1)
                    {
                        enemyInstance.Heal(enemyInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 2)
                    {
                        enemyInstance.weaken(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 3)
                    {
                        enemyInstance.Strength(charaInstance);
                    }

                    Console.WriteLine("君のHP = " + charaInstance.HP + " 攻撃力 = " + charaInstance.Damage);
                    Console.WriteLine("敵のHP = " + enemyInstance.HP + " 攻撃力 = " + enemyInstance.Damage + "\n");

                }
                else if (atk == 'E' || atk == 'e')
                {
                    charaInstance.weaken(enemyInstance);
                    Random enemyatk = new Random();
                    if (enemyatk.Next(0, 3) == 0)
                    {
                        enemyInstance.Attack(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 1)
                    {
                        enemyInstance.Heal(enemyInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 2)
                    {
                        enemyInstance.weaken(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 3)
                    {
                        enemyInstance.Strength(charaInstance);
                    }

                    Console.WriteLine("君のHP = " + charaInstance.HP + " 攻撃力 = " + charaInstance.Damage);
                    Console.WriteLine("敵のHP = " + enemyInstance.HP + " 攻撃力 = " + enemyInstance.Damage + "\n");

                }
                else if (atk == 'R' || atk == 'r')
                {
                    charaInstance.Strength(enemyInstance);
                    Random enemyatk = new Random();
                    if (enemyatk.Next(0, 3) == 0)
                    {
                        enemyInstance.Attack(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 1)
                    {
                        enemyInstance.Heal(enemyInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 2)
                    {
                        enemyInstance.weaken(charaInstance);
                    }
                    else if (enemyatk.Next(0, 3) == 3)
                    {
                        enemyInstance.Strength(charaInstance);
                    }

                    Console.WriteLine("君のHP = " + charaInstance.HP + " 攻撃力 = " + charaInstance.Damage);
                    Console.WriteLine("敵のHP = " + enemyInstance.HP + " 攻撃力 = " + enemyInstance.Damage + "\n");

                }
            }

            if (charaInstance.HP <= 0)
            {
                Console.WriteLine("\n負けです");
            }
            else if (enemyInstance.HP <= 0)
            {
                Console.WriteLine("\n勝ちです");
            }
        }
    }
}