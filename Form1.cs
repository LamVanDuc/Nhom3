namespace Dictionary
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var My_Dictionary = new Dictionary<string, string>()
            {
                {"mouse","a small mammal with short fur, a pointed face, and a long tail" },
                {"keyboard", "the set of keys on a computer or typewriter that you press in order to make it work " },
                {"java", "the name of a computer programming language that is often used on the internet" },
                {"computer", "an electronic machine that is used for storing, organizing, and finding words, numbers, and pictures, for doing calculations, and for controlling other machines" },
                {"c++", "the name of a computer programming language that is often used on the internet" },
                {"apple", "a round fruit with firm, white flesh and a green, red, or yellow skin" },
                {"dog", "a common animal with four legs, especially kept by people as a pet or to hunt or guard things"},
            };

            string word;
            word = inputbox.Text;

            try
            {
                resultbox.Text = My_Dictionary[word];  
            }
            catch
            {
                resultbox.Text = "Not found!";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}