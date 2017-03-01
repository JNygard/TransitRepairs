using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model {
    class Player {

        public String name;
        public float balance;

        public int weldingGas;
        public int weldingWire;

        private int weldingspeed = 2;
        private int gasSpeed = 15;
        private int wireSpeed = 7;


        public Player(String name, float balance) {
            this.name = name;
            this.balance = balance;
            this.weldingGas = 10000;
            this.weldingWire = 6000;
        }

        public Car weldCar(Car car) {
            if (car.weldedPrcentage < 100 && weldingWire-wireSpeed>=0 && weldingGas- gasSpeed>=0) {
                car.weldedPrcentage += weldingspeed;
                weldingGas -= gasSpeed;
                weldingWire -= wireSpeed;
            }
            return car;
        }

    }
}
