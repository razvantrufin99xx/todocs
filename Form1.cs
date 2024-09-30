namespace todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            s = this.textBox1.Text + " , " + this.textBox2.Text + "";
            this.listBox1.Items.Add(s);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            

                string ss = "";
                string sss = "";
                string ssss = listBox1.SelectedItem.ToString();
                
                //Text = "Text is : "  + ssss + " : ";
                int k = ssss.IndexOf(",");
                //Text += "pos of , is :  "+k.ToString();
                int l = ssss.Length;
                //Text += " : lenght text is = " + l.ToString() + " : " ; 
                ss = ssss.Substring(0, k);
                //Text += "substring 0 to , is : " + ss + " : " ;
                sss = ssss.Substring(k+1, (l-1)-k);
                //Text += "substring final k to length of ssss is : " + sss + " ";
                this.textBox4.Text = ss;
                this.textBox3.Text = sss;
            }
            catch { };

        }
    }
}
