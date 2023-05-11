namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            checkBox1.Checked = false;
            checkBox1.Enabled = true;
            label3.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chk_pass_len() == false)
            {
                MessageBox.Show("Haslo ponizej 8 znakow!!","err",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else if (textBox1 != null && textBox2 != null && checkBox1.Checked)
            {
                if (chk_password() == true)
                {
                    string msgbox = textBox1.Text +" "+ textBox2.Text;
                    MessageBox.Show(msgbox,"WYNIK",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
#pragma warning disable CS8602 // Wy³uskanie odwo³ania, które mo¿e mieæ wartoœæ null.
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("brak loginu", "ERR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("brak hasla", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkBox1.Checked != true)
                {
                    MessageBox.Show("brak zgody", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
#pragma warning restore CS8602 // Wy³uskanie odwo³ania, które mo¿e mieæ wartoœæ null.
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public bool chk_password()
        {
            if (textBox2.Text == textBox3.Text)
            {
                label3.Text = "hasla zgodne";
                return true;
            }
            else
            {
                label3.Text = "hasla nie zgodne";
                return false;

            }

        }

        public bool chk_pass_len()
        {
            if (textBox2.Text.Count() >= 8) {
                return true;
            }
            else
            {
            return false;

            }
        }


    }


}
