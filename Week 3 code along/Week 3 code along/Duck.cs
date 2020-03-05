using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_code_along
{
    class Duck
    {
        public string Name;
        public int Age;
        public int attackDamage;

        public void Honk()
        {
            MessageBox.Show("Honk, mi nombre es " + Name + " y tengo " + Age + " anos");
        }

        public void AQuack()
        {
            MessageBox.Show("You just got shrunkt.. -" + attackDamage + " hp");
        }
    }
}
