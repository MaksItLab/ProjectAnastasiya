using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Entities
{
    public class Enemy
    {
        public static int health = 100;

        public void Damage(int damage)
        {
            health -= damage;
        }

        public void DisplayHealth()
        {
            Console.WriteLine("Здоровье: " + health);
        }
    }
}
