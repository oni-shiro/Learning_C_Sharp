using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Animal
    {
        private string name;
        private int height;

        private int weight;

        public Animal(){
            
        }
        public Animal(string name, int height, int weight){
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        public string Name{
            get{
                return this.name; 
            }
            set{
                this.name= value;
            }
        }

        public int Height{
            get{
                return this.height; 
            }
            set{
                this.height= value;
            }
        }

        public int Weight{
            get{
                return this.weight; 
            }
            set{
                this.weight= value;
            }
        }

        public bool IsHealthy(){
            if(weight/height>2) return true;
            return false;
        }

        public virtual void call(){
            Console.WriteLine("No sound");
        }

    }
}