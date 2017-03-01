using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Model {
    class Shop {
        public List<Part> parts;

        public Shop() {
            this.parts = new List<Part>();

            this.parts.Add(new Part("brakes", "imagepath", true, false, 20));



            this.parts.Add(new Part("suspension", "imagepath", true, true, 200));
            this.parts.Add(new Part("gearbox", "imagepath", true, true, 1200));
            this.parts.Add(new Part("engine", "imagepath", true, true, 5000));
            this.parts.Add(new Part("exhaust", "imagepath", true, true, 200));
            this.parts.Add(new Part("clutch", "imagepath", true, true, 200));
            this.parts.Add(new Part("tires", "imagepath", true, true, 700));
        }

        public Part getItemByName(String partName) {
            foreach (Part p in this.parts) {
                if (partName.Equals(p.name)) {
                    return p;
                }

            }

            return null;
        }


    }
}
