using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using ShadowOptimizer.Properties;


namespace ShadowOptimizer
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

        private void Button3_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
		{
            Random rand = new Random();
            long randomNumber = (long)(rand.NextDouble() * 1000000000000);
            label13.Text = randomNumber.ToString();

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create("config.txt"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("Settings = Dynamic");

                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

		private void Button1_Click(object sender, EventArgs e)
		{
			ColorDialog MyDialog = new ColorDialog
			{
				// Keeps the user from selecting a custom color.
				AllowFullOpen = false,
				// Allows the user to get help. (The default is false.)
				ShowHelp = true,
				// Sets the initial color select to the current text color.
				Color = button1.ForeColor // inizialmente usa il colore di button1
			};

			// Visualizza il ColorDialog
			if (MyDialog.ShowDialog() == DialogResult.OK)
			{
				// Imposta il colore selezionato su tutti i controlli
				button1.ForeColor = MyDialog.Color;
				label1.ForeColor = MyDialog.Color;
				label2.ForeColor = MyDialog.Color;
				label3.ForeColor = MyDialog.Color;
				label4.ForeColor = MyDialog.Color;
				label5.ForeColor = MyDialog.Color;
				label6.ForeColor = MyDialog.Color;
				label7.ForeColor = MyDialog.Color;
				label8.ForeColor = MyDialog.Color;
				label9.ForeColor = MyDialog.Color;
				label10.ForeColor = MyDialog.Color;
				label11.ForeColor = MyDialog.Color;
				label12.ForeColor = MyDialog.Color;
				label13.ForeColor = MyDialog.Color;
				label14.ForeColor = MyDialog.Color;
				label15.ForeColor = MyDialog.Color;
				label16.ForeColor = MyDialog.Color;
				label17.ForeColor = MyDialog.Color;
				label18.ForeColor = MyDialog.Color;
				label19.ForeColor = MyDialog.Color;
				label20.ForeColor = MyDialog.Color;
				label21.ForeColor = MyDialog.Color;
				label22.ForeColor = MyDialog.Color;
				label23.ForeColor = MyDialog.Color;
				label24.ForeColor = MyDialog.Color;
				label25.ForeColor = MyDialog.Color;
				label26.ForeColor = MyDialog.Color;
                label27.ForeColor = MyDialog.Color;
				label28.ForeColor = MyDialog.Color;
                label29.ForeColor = MyDialog.Color;
				label30.ForeColor = MyDialog.Color;
				button3.ForeColor = MyDialog.Color;
				label31.ForeColor = MyDialog.Color;
				label32.ForeColor = MyDialog.Color;
				
            }
		}

		

		public void TextBox2_TextChanged(object sender, EventArgs e)
		{
			// Assicurati che "frm1" sia correttamente gestito
			label17.Text = textBox2.Text; // Imposta direttamente il testo
		}

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
			label18.Text = textBox3.Text;
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
			MessageBox.Show("Da adesso le configurazioni verranno salvate nel file .config");
        }

    }
}