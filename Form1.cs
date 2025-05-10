using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Diagnostics.Tracing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Deployment.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ShadowOptimizer
{
    public partial class ShadowForm : Form
    {
        private readonly IEnumerable<string> args; // Ensure this is initialized before use, perhaps in constructor

        public ShadowForm(IEnumerable<string> args)
        {
            this.args = args;
        }

        public ShadowForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Renamed to match class name
        {
            string filletto = @"log.txt";
            if (File.Exists(filletto))
            {
                ;
            }
            else
            {
                MessageBox.Show("Benvenuto in ShadowOptimizer V3.1.0!");
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create("log.txt"))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("ShadowOptimizer V4. Done Finished Loading...");

                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    
        private bool ShadowOptimizer()
        {
            // Implement your optimizer logic here or return true/false depending on the condition
            return true; // Placeholder
        }

        private static bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            string user = WindowsIdentity.GetCurrent().Name;
            Console.WriteLine($"Lavorando nell'utente: {user}");
            Console.WriteLine("Loading...");
            bool checkBox1Value = frm2.checkBox1.Checked;



            // Clean user Temp folder
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp");
            if (checkBox1Value)
            {
                foreach (string filename in Directory.GetFiles(folder))
                {
                    try
                    {
                        File.Delete(filename); // Removes file or symbolic link
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder}: {ex.Message}");
                    }
                }

                foreach (string directory in Directory.GetDirectories(folder))
                {
                    try
                    {
                        Directory.Delete(directory, true); // Remove non-empty directory
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder}: {ex.Message}");
                    }
                }
            }
            else
            {
                ;
            }

            // Clean Windows\Temp folder
            string folder2 = @"C:\Windows\Temp";
            bool checkBox2Value = frm2.checkBox2.Checked;
            if (checkBox2Value)
            {
                foreach (string filename in Directory.GetFiles(folder2))
                {
                    try
                    {
                        File.Delete(filename); // Removes file or symbolic link
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder2}: {ex.Message}");
                    }
                }

                foreach (string directory in Directory.GetDirectories(folder2))
                {
                    try
                    {
                        Directory.Delete(directory, true); // Remove non-empty directory
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder2}: {ex.Message}");
                    }
                }
            }
            else
            {
                ;
            }

            // Remove Windows.old folder
            string path = @"C:\Windows.old";
            bool checkBox4Value = frm2.checkBox4.Checked;
            if (checkBox4Value)
            {
                try
                {
                    Directory.Delete(path, true); // Removes non-empty directory
                    Console.WriteLine($"Cartella {path} rimossa con successo!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore durante la rimozione della cartella {path}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"La cartella {path} non esiste.");
            }

            string folder3 = @"C:\Windows\Prefetch";
            bool checkBox3Value = frm2.checkBox3.Checked;
            if (checkBox3Value)
            {
                foreach (string filename in Directory.GetFiles(folder3))
                {
                    try
                    {
                        File.Delete(filename); // Removes file or symbolic link
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder3}: {ex.Message}");
                    }
                }

                foreach (string directory in Directory.GetDirectories(folder3))
                {
                    try
                    {
                        Directory.Delete(directory, true); // Removes non-empty directory
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder3}: {ex.Message}");
                    }
                }
            }
            else
            {
                ;
            }
            string folder4 = @"C:\$Recycle.Bin";
            bool checkBox6Value = frm2.checkBox6.Checked;
            if (checkBox6Value)
            {
                foreach (string filename in Directory.GetFiles(folder4))
                {
                    try
                    {
                        File.Delete(filename); // Removes file or symbolic link
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder4}: {ex.Message}");
                    }
                }

                foreach (string directory in Directory.GetDirectories(folder4))
                {
                    try
                    {
                        Directory.Delete(directory, true); // Removes non-empty directory
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder4}: {ex.Message}");
                    }
                }
            }
            else
            {
                ;
            }
            string utente20 = Environment.UserName;
            string folder5 = $@"C:\Users\{utente20}\Downloads";
            bool checkBox7Value = frm2.checkBox7.Checked;
            if (checkBox7Value)
            {
                foreach (string filename in Directory.GetFiles(folder5))
                {
                    try
                    {
                        File.Delete(filename); // Removes file or symbolic link
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder5}: {ex.Message}");
                    }
                }

                foreach (string directory in Directory.GetDirectories(folder5))
                {
                    try
                    {
                        Directory.Delete(directory, true); // Removes non-empty directory
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder5}: {ex.Message}");
                    }

                }
            }
            else
            {
                ;
            }
            string utente21 = Environment.UserName;
            string folder6 = $@"C:\Users\{utente21}\AppData\Local\Microsoft\Windows\INetCache\IE";
            bool checkBox8Value = frm2.checkBox8.Checked;
            if (checkBox8Value)
            {
                foreach (string filename in Directory.GetFiles(folder6))
                {
                    try
                    {
                        File.Delete(filename); // Removes file or symbolic link
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder6}: {ex.Message}");
                    }
                }

                foreach (string directory in Directory.GetDirectories(folder6))
                {
                    try
                    {
                        Directory.Delete(directory, true); // Removes non-empty directory
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore durante la pulizia della cartella {folder6}: {ex.Message}");
                    }
                    
                    string folder7 = $@"C:\Windows\Logs";
                    bool checkBox9Value = frm2.checkBox9.Checked;
                    if (checkBox9Value)
                    {
                        foreach (string filename in Directory.GetDirectories(folder7))
                        {
                            try
                            {
                                Directory.Delete(folder7);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Errore durante la pulizia della cartella {folder7}: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        ;
                    }
                }
            }
            else
            {
                ;
            }
            Console.WriteLine("Done :DDDD");

            // Initialize progress bar
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;

            // Update progress bar
            for (int i = 0; i < 100; i++)
            {
                progressBar1.PerformStep();
                await Task.Delay(50); // Asynchronous delay to prevent UI freezing

            }
            MessageBox.Show("DONE :DDDD, enjoy un new PC!");
            MessageBox.Show("Finished Clean. Press OK to close window");
            Application.Exit(); // Close application
        }
    }
}