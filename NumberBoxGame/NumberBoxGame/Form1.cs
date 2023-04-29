namespace NumberBoxGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int movesNumber = 0, labelIndex = 0;

        private void shuffleButtons()
        {
            List<int> labellist = new List<int>();
            Random r = new Random();
            foreach (Button btn in this.panel1.Controls)
            {
                while (labellist.Contains(labelIndex))
                    labelIndex = r.Next(16);
                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                labellist.Add(labelIndex);

            }
            movesNumber = 0;
            label1.Text = "Total Move " + movesNumber;
        }

        private void swapLabel(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
                return;

            Button whiteBtn = null;
            foreach (Button bt in this.panel1.Controls)
            {
                if (bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }
            if (btn.TabIndex == (whiteBtn.TabIndex - 1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 4) ||
                btn.TabIndex == (whiteBtn.TabIndex + 1) ||
                btn.TabIndex == (whiteBtn.TabIndex + 4))
            {
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                movesNumber++;
                label1.Text = " Number of moves : " + movesNumber;
            }
            checkOrder();
        }

        private void checkOrder()
        {
            if (button1.Text == "1")
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
            if (button2.Text == "2")
            {
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
            if (button3.Text == "3")
            {
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
            if (button4.Text == "4")
            {
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
            if (button5.Text == "5")
            {
                button5.BackColor = Color.Green;
            }
            else
            {
                button5.BackColor = Color.Red;
            }
            if (button6.Text == "6")
            {
                button6.BackColor = Color.Green;
            }
            else
            {
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "7")
            {
                button7.BackColor = Color.Green;
            }
            else
            {
                button7.BackColor = Color.Red;
            }
            if (button8.Text == "8")
            {
                button8.BackColor = Color.Green;
            }
            else
            {
                button8.BackColor = Color.Red;
            }
            if (button9.Text == "9")
            {
                button9.BackColor = Color.Green;
            }
            else
            {
                button9.BackColor = Color.Red;
            }
            if (button10.Text == "10")
            {
                button10.BackColor = Color.Green;
            }
            else
            {
                button10.BackColor = Color.Red;
            }
            if (button11.Text == "11")
            {
                button11.BackColor = Color.Green;
            }
            else
            {
                button11.BackColor = Color.Red;
            }
            if (button12.Text == "12")
            {
                button12.BackColor = Color.Green;
            }
            else
            {
                button12.BackColor = Color.Red;
            }
            if (button13.Text == "13")
            {
                button13.BackColor = Color.Green;
            }
            else
            {
                button13.BackColor = Color.Red;
            }
            if (button14.Text == "14")
            {
                button14.BackColor = Color.Green;
            }
            else
            {
                button14.BackColor = Color.Red;
            }
            if (button15.Text == "15")
            {
                button15.BackColor = Color.Green;
            }
            else
            {
                button15.BackColor = Color.Red;
            }

            if ((button1.Text == "1") && (button2.Text == "2") && (button3.Text == "3") &&
                (button4.Text == "4") && (button5.Text == "5") && (button6.Text == "6") &&
                (button7.Text == "7") && (button8.Text == "8") && (button9.Text == "9") &&
                (button10.Text == "10") && (button11.Text == "11") && (button12.Text == "12") &&
                (button13.Text == "13") && (button14.Text == "14") && (button15.Text == "15"))
            {
                MessageBox.Show("TEBRÝKLER ! OYUNU " + movesNumber + " HAMLEDE KAZANDINIZ !");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            shuffleButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}