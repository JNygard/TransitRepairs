using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

using WMPLib;

using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1 {
    public partial class MainGame : Form {

        //Game
        private Car myCar;
        private Shop shop;
        private Player player;

        private Boolean gameOn;

        //time
        private System.Windows.Forms.Timer timer1;
        private int counter;

        //Music & audio
        private WindowsMediaPlayer wmp;
        private Boolean bPlay;
        private WindowsMediaPlayer weldingSound;
        private Boolean bweldingSound;
        private SoundPlayer cashSound;
        private SoundPlayer commentary;

        
        public MainGame() {
            InitializeComponent();
        }

        public void newGame() {
            //Game
            myCar = new Car();
            shop = new Shop();
            player = new Model.Player("Matti", 10000);
            gameOn = true;

            //Time
            counter = 40;

            //Music & audio
            wmp = new WindowsMediaPlayer();
            wmp.URL = @"http://www.orangefreesounds.com/wp-content/uploads/2016/10/Terra-incognita-instrumental-background-music.mp3";
            weldingSound = new WindowsMediaPlayer();
            cashSound = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.cash);
            commentary = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.startgame);
            commentary.Play();
            bPlay = true;
            bweldingSound = false;

            setUpCar();
            IVtransit.Image = WindowsFormsApplication1.Properties.Resources.pieniromu2;
            setUpShop();
            setupBalance();

            startClock();
        }

        //game over
        public void gameOver(int win) {
            
            if (win == 0) {
                IVtransit.Image = WindowsFormsApplication1.Properties.Resources.transitpaalattu;
                commentary = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.losegame);
            }
            else if (win == 1) {
                IVtransit.Image = WindowsFormsApplication1.Properties.Resources.transitvalmispieni2;
                commentary = new SoundPlayer(WindowsFormsApplication1.Properties.Resources.wingame);
            }
            cashSound.Stop();
            commentary.Play();
            wmp.close();
            bPlay = false;

            gameOn = false;
            timer1.Stop();


        }


        //updates top info bar
        public void updateInfobar() {
            TBpartsPercentage.Text = myCar.getPartsPrcentage().ToString();
            TBweldedPercentage.Text = myCar.weldedPrcentage.ToString();
            TBweldingWire.Text = player.weldingWire.ToString();
            TBweldingGas.Text = player.weldingGas.ToString();

            if(myCar.getPartsPrcentage() >= 100 && myCar.weldedPrcentage >= 100) {
                gameOver(1);
            }
            
        }

        //set up car
        public void setUpCar() {
            LVfailureList.Items.Clear();
            foreach (Part p in this.myCar.parts) {
                if (!p.unbroken)
                    LVfailureList.Items.Add(p.name + "[BROKEN]");
                else
                    LVfailureList.Items.Add(p.name);
            }
            updateInfobar();
        }

        //list shop items
        public void setUpShop() {
            CBshopChoosePart.Items.Clear();
            foreach (Part p in this.shop.parts) {
                CBshopChoosePart.Items.Add(p.name);
            }
        }
        public void setupBalance() {
            TBbankBalance.Text = player.balance.ToString();
        }

        //Click buy
        private void button_buy(object sender, EventArgs e) {
            if (!gameOn)
                return;
            Part p = this.myCar.getPartByName(CBshopChoosePart.Text);
            if (p.unbroken) {
                MessageBox.Show("You already have functioning " + p.name);
            }else {
                Part newPart = shop.getItemByName(p.name);
                if (player.balance - newPart.price >= 0) {
                    myCar.parts.Add(newPart);
                    myCar.parts.Remove(p);
                    setUpCar();
                    player.balance -= newPart.price;
                    setupBalance();
                    TBpartsPercentage.Text = myCar.getPartsPrcentage().ToString();
                    cashSound.Play();
                }
                else {
                    MessageBox.Show("You dont have enough money " + p.name);
                }

               
            }
        }

        //Current shop item changed
        private void CBshopChoosePart_SelectedValueChanged(object sender, EventArgs e) {
            Part p = this.shop.getItemByName(CBshopChoosePart.Text);
            TBpartPrice.Text = p.price.ToString();
            setItemImage(p.name);

        }

        //Speaker clicked
        private void click_speaker(object sender, MouseEventArgs e) {
            if (!bPlay) {
                wmp.URL = @"http://www.orangefreesounds.com/wp-content/uploads/2016/10/Terra-incognita-instrumental-background-music.mp3";
                bPlay = true;
            }else {
                wmp.close();
                bPlay = false;
            }
        }


        //Clicked welder
        private void click_welder(object sender, EventArgs e) {
            if (!gameOn)
                return;
            if(weldingSound.playState == WMPPlayState.wmppsStopped || weldingSound.playState == WMPPlayState.wmppsUndefined)
                weldingSound.URL = @"https://freesound.org/data/previews/368/368705_528777-lq.mp3";
            myCar = player.weldCar(myCar);
            updateInfobar();
        }












        //Other

        //Time
        private void startClock() {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            TBtimeLeft.Text = counter.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e) {
            counter--;
            if (counter == 0) {
                gameOver(0);
            }
                
            TBtimeLeft.Text = counter.ToString();
        }


        //Set shop item image. Should fix this somehow..
        public void setItemImage(String pname) {
            if (pname.Equals("clutch")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.clutch;
            }
            else if (pname.Equals("tires")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.tire1;
            }
            else if (pname.Equals("suspension")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.suspension1;
            }
            else if (pname.Equals("gearbox")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.gearbox;
            }
            else if (pname.Equals("engine")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.engine;
            }
            else if (pname.Equals("exhaust")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.exhaust;
            }
            else if (pname.Equals("brakes")) {
                PBshopItem.Image = WindowsFormsApplication1.Properties.Resources.brake1;
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e) {

        }
    }
}
