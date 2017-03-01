using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1 {
    class Car {
        public Boolean running;
        public List<Part> parts;
        public String color;
        public int weldedPrcentage;
        public int partsPrcentage;

        public Car() {
            this.running = false;
            this.parts = new List<Part>();
            this.color = "red";
            this.weldedPrcentage = 1;
            this.partsPrcentage = 1;
            buildCar();
        }

        private void buildCar() {
            this.parts.Add(new Part("brakes", "imagepath", false, false, 20));

            this.parts.Add(new Part("suspension", "imagepath", false, true, 200));
            this.parts.Add(new Part("gearbox", "imagepath", false, true, 1200));
            this.parts.Add(new Part("engine", "imagepath", false, true, 200));
            this.parts.Add(new Part("exhaust", "imagepath", false, true, 200));
            this.parts.Add(new Part("clutch", "imagepath", false, true, 5000));
            this.parts.Add(new Part("tires", "imagepath", false, true, 700));

        }
        

        public int getPartsPrcentage() {
            float d;
            float i = 0;
            float notBroken = 0;

            foreach (Part p in this.parts) {
                if (p.unbroken)
                    notBroken++;
                i++;
            }
            d = notBroken / i;
            d = d * 100;


            return (int)d;
        }

        public Part getPartByName(String partName) {
            foreach (Part p in this.parts) {
                if (partName.Equals(p.name)) {
                    return p;
                }

            }

            return null;
        }




    }
}
