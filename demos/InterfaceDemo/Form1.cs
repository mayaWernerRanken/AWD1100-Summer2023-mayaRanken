namespace InterfaceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDemoChamps_Click(object sender, EventArgs e)
        {
            Hecarim myChamp = new Hecarim() { Health = 625, HealthRegen = 7, Armor = 32, MagicResist = 32, MoveSpeed = 345 };
            Hecarim clone = (Hecarim)myChamp.Clone();
            Hecarim yourChamp = new Hecarim() { Health = 100, HealthRegen = 7, Armor = 32, MagicResist = 32, MoveSpeed = 345 };
            clone.Health = 700;

            Hecarim[] hecarims = new Hecarim[] {myChamp, clone, yourChamp};

            Array.Sort(hecarims);

            for (int i = 0; i < hecarims.Length; i++)
            {
                lblResult.Text += hecarims[i].ToString();
            }


        }

        //private void ChampDemo(Champion c1)
        //{

        //}

        private void ChampDemo(IRability c1)
        {
            lblResult.Text += c1.Ultimate();
        }
    }
}