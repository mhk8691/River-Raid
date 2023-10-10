using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace River_Raid


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

            foreach (Button Btn in this.Controls)
            {

                if (Btn is Button)
                {
                    Btn.FlatStyle = FlatStyle.Flat;
                    Btn.FlatAppearance.BorderSize = 0;
                    Btn.FlatAppearance.MouseOverBackColor = Color.Blue;

                    Btn.BackColor = Color.Red;
                    Btn.ForeColor = Color.White;
                    Btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Btn.Width, Btn.Height, 20, 20));

                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 startgame = new Form2();
            startgame.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای شروع بازی شما صاحب یک جت جنگی هستید که باید با استفاده از آن دشمنان خود را نابود کنید \r\nبرای به چپ و راست رفتن با هواپیما باید از کلید چپ کیبورد راست کیبورد استفاده کنید \r\nو با استفاده از کلیک چپ موس  شلیک میکنید\r\n ", " راهنمای بازی", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}