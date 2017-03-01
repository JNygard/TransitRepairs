using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model {
    class Part {
        public String name;
        public String imgPath;
        public Boolean unbroken;
        public Boolean necessary;
        public float price;

        public Part(String name, String imgPath, Boolean unbroken, Boolean necessary, float price) {
            this.name = name;
            this.imgPath = imgPath;
            this.unbroken = unbroken;
            this.necessary = necessary;
            this.price = price;

        }




    }
}
