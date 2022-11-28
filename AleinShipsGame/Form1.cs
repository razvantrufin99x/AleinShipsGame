namespace AleinShipsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics g;

        public Game ga = new Game();
        public AliensFleet fl = new AliensFleet();
        public Ship PlayerShip = new Ship();
        public Bullet bullet = new Bullet();
        public int currentRow = 5;
        public int currentCollumn = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.Focus();

            ga.f = this;

            PlayerShip.x = 500;
            PlayerShip.y = 700;
            PlayerShip.width = 20;
            PlayerShip.height = 20;
            PlayerShip.color = Color.Blue;

            bullet.x = 500;
            bullet.y = 500;
            bullet.width = 2;
            bullet.height = 10;
            bullet.color = Color.Green;

            g.DrawRectangle(new Pen(PlayerShip.color), PlayerShip.x, PlayerShip.y, PlayerShip.width, PlayerShip.height);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    fl.TheFleet.Add(new Ship(i*10*currentCollumn+30, j*10*currentRow+30, Color.Red, 20, 20));
                }
            }

            g.DrawRectangle(new Pen(bullet.color), bullet.x, bullet.y, bullet.width, bullet.height);


            for (int i = 0; i < fl.TheFleet.Count; i++)
            {
                g.DrawRectangle(new Pen(Color.Black), fl.TheFleet[i].x, fl.TheFleet[i].y, fl.TheFleet[i].width, fl.TheFleet[i].height);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            g.Clear(Color.White);
            Text = e.KeyChar.ToString();
            if (Text == "s" || Text == "S") { PlayerShip.y += 0; }
            else if (Text == "a" || Text == "A") { PlayerShip.x -= 21; currentCollumn -= 2; currentRow = 0; }
            else if (Text == "d" || Text == "D") { PlayerShip.x += 21; currentCollumn += 2; currentRow = 0; }
            else if (Text == "w" || Text == "W") { PlayerShip.y -= 0; currentRow += 2; }
            else if (Text == "l" || Text == "L") {  }
            else { }



            //at clock tact
            bullet.y--;
            if (bullet.y == 5) { 
                bullet.y = 500;
            }
            //move the bullet
            g.DrawRectangle(new Pen(bullet.color), bullet.x, bullet.y, bullet.width, bullet.height);
            
            
            //move the player

            g.DrawRectangle(new Pen(PlayerShip.color), PlayerShip.x, PlayerShip.y, PlayerShip.width, PlayerShip.height);






            //move all fleet
           
            
           
            for (int j = 0; j < fl.TheFleet.Count; j++)
                {
                    fl.TheFleet[j].x += currentCollumn;
                    fl.TheFleet[j].y += currentRow;
                ;    
                }
            


            for (int i = 0; i < fl.TheFleet.Count; i++)
            {
                
                    g.DrawRectangle(new Pen(Color.Black), fl.TheFleet[i].x, fl.TheFleet[i].y, fl.TheFleet[i].width, fl.TheFleet[i].height);
               

            }
            
        }
    }
}