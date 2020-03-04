using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week3CodeAlong
{
    class Dog
    {
        public string breed;
        public int height;
        public string name;

        public void Bark()
        {
            MessageBox.Show("Bork!");
        }

        public void SayName()
        {
            
            MessageBox.Show("My Name is " + name);
        }
    }
}
