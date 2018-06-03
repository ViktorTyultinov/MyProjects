using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proconsult_Table_Constructor
{
    public partial class Form1 : Form
    {
        Company myCompany;
        public Form1()
        {
            InitializeComponent();
            myCompany = new Company();
            bnFileExtraction_Click(null, null);
        }

        private void bnFileExtraction_Click(object sender, EventArgs e)
        {
            string[] item;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName),Encoding.Default);
                string s = sr.ReadLine();
                while (s != null)
                {
                    item = s.Split(',');
                    myCompany.addItem(new Item(item[0], item[1], item[2], item[3],item[4], 999999));
                    item = null;
                    s = sr.ReadLine();
                }
                sr.Dispose();
            }

            foreach (var product in myCompany.returnItems())
            {
                listBox1.Items.Add(product.ToString());
            }
        }

        private void bnDiamantenaTeh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Диамантена техника");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnVintonavivnaTeh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Винтонавивна техника");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnDubelnaTeh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Дюбелна техника");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnKurteshtaTeh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Ударно-пробивна и къртеща техника");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnStroitelnaHim_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Строителна химия");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnInstalacionaTeh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Инсталационна техника");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnDurvoprobivashtaTeh_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Дървообработваща техника");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnPironi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Пирони за монтаж");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnElektrodi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Електроди");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnIzolacionniMat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Изолационни материали");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnPoliesterniKolani_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Полиестерни колани");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnRazni_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Разни");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnBezGrupa_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Без група");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void bnLichniPredpazniSredstva_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Item> temp = myCompany.returnCategory("Лични предпазни средства");
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            FileStream fs = null;
            StreamWriter sw = null;

            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("<CATALOG>");

                    foreach (var item in temp)
                    {
                        sw.WriteLine(item.ToString());
                    }
                    sw.WriteLine("</CATALOG>");
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            foreach (var item in temp)
            {
                listBox1.Items.Add(item.ToString());
            }

        }
    }
}
