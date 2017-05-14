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


namespace Week7Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("1920");
            listBox2.Items.Add("1921");
            listBox2.Items.Add("1922");
            listBox2.Items.Add("1923");
            listBox2.Items.Add("1924");
            listBox2.Items.Add("1925");
            listBox2.Items.Add("1926");
            listBox2.Items.Add("1927");
            listBox2.Items.Add("1928");
            listBox2.Items.Add("1929");
            listBox2.Items.Add("1930");
            listBox2.Items.Add("1931");
            listBox2.Items.Add("1932");
            listBox2.Items.Add("1933");
            listBox2.Items.Add("1934");
            listBox2.Items.Add("1935");
            listBox2.Items.Add("1936");
            listBox2.Items.Add("1937");
            listBox2.Items.Add("1938");
            listBox2.Items.Add("1939");
            listBox2.Items.Add("1940");
            listBox2.Items.Add("1941");
            listBox2.Items.Add("1942");
            listBox2.Items.Add("1943");
            listBox2.Items.Add("1944");
            listBox2.Items.Add("1945");
            listBox2.Items.Add("1946");
            listBox2.Items.Add("1947");
            listBox2.Items.Add("1948");
            listBox2.Items.Add("1949");
            listBox2.Items.Add("1950");
            listBox2.Items.Add("1951");
            listBox2.Items.Add("1952");
            listBox2.Items.Add("1953");
            listBox2.Items.Add("1954");
            listBox2.Items.Add("1955");
            listBox2.Items.Add("1956");
            listBox2.Items.Add("1957");
            listBox2.Items.Add("1958");
            listBox2.Items.Add("1959");
            listBox2.Items.Add("1960");
            listBox2.Items.Add("1961");
            listBox2.Items.Add("1962");
            listBox2.Items.Add("1963");
            listBox2.Items.Add("1964");
            listBox2.Items.Add("1965");
            listBox2.Items.Add("1966");
            listBox2.Items.Add("1967");
            listBox2.Items.Add("1968");
            listBox2.Items.Add("1969");
            listBox2.Items.Add("1970");
            listBox2.Items.Add("1971");
            listBox2.Items.Add("1972");
            listBox2.Items.Add("1973");
            listBox2.Items.Add("1974");
            listBox2.Items.Add("1975");
            listBox2.Items.Add("1976");
            listBox2.Items.Add("1977");
            listBox2.Items.Add("1978");
            listBox2.Items.Add("1979");
            listBox2.Items.Add("1980");
            listBox2.Items.Add("1981");
            listBox2.Items.Add("1982");
            listBox2.Items.Add("1983");
            listBox2.Items.Add("1984");
            listBox2.Items.Add("1985");
            listBox2.Items.Add("1986");
            listBox2.Items.Add("1987");
            listBox2.Items.Add("1988");
            listBox2.Items.Add("1989");
            listBox2.Items.Add("1990");
            listBox2.Items.Add("1991");
            listBox2.Items.Add("1992");
            listBox2.Items.Add("1993");
            listBox2.Items.Add("1994");
            listBox2.Items.Add("1995");
            listBox2.Items.Add("1996");
            listBox2.Items.Add("1997");
            listBox2.Items.Add("1998");
            listBox2.Items.Add("1999");
            listBox2.Items.Add("2000");
            listBox2.Items.Add("2001");
            listBox2.Items.Add("2002");
            listBox2.Items.Add("2003");
            listBox2.Items.Add("2004");
            listBox2.Items.Add("2005");
            listBox2.Items.Add("2006");
            listBox2.Items.Add("2007");
            listBox2.Items.Add("2008");
            listBox2.Items.Add("2009");
            listBox2.Items.Add("2010");
            listBox2.Items.Add("2011");
            listBox2.Items.Add("2012");
            listBox2.Items.Add("2013");
            listBox2.Items.Add("2014");

            listBox1.Items.Clear(); // use this to clear the previous years' movie results
            {
                var lines = File.ReadAllLines("MovieList.txt");
                foreach (var item in lines)
                {
                    listBox1.Items.Add(item); // adds all the movies before anything is selected 
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // use this to clear the previous years' movie results
            {
                var lines = File.ReadAllLines("MovieList.txt");
                foreach (var item in lines)
                {
                    // listBox1.Items.Add(item); // adds all the movies before anything is selected 
                }
                if (listBox2.SelectedItem == "1920") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(0) // skip this number of lines in the text file 
                                                       .Take(3); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1921") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(3) // skip this number of lines in the text file 
                                                       .Take(2); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1922") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(5) // skip this number of lines in the text file 
                                                       .Take(2); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }

                if (listBox2.SelectedItem == "1923") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(7) // skip this number of lines in the text file 
                                                       .Take(2); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1924") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(9) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1925") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(13) // skip this number of lines in the text file 
                                                       .Take(6); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1926") // example year to use 
                {
                    listBox1.Items.Add("No movies to display");
                }
                if (listBox2.SelectedItem == "1927") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(19) // skip this number of lines in the text file 
                                                       .Take(2); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1928") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(21) // skip this number of lines in the text file 
                                                       .Take(2); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1929") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(23) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1930") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(27) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1931") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(31) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1932") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(35) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1933") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(39) // skip this number of lines in the text file 
                                                       .Take(6); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1934") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(45) // skip this number of lines in the text file 
                                                       .Take(5); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1935") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(50) // skip this number of lines in the text file 
                                                       .Take(8); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1936") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(58) // skip this number of lines in the text file 
                                                       .Take(8); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1937") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(66) // skip this number of lines in the text file 
                                                       .Take(2); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1938") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(68) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1939") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(72) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1940") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(76) // skip this number of lines in the text file 
                                                       .Take(12); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1941") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(88) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1942") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(92) // skip this number of lines in the text file 
                                                       .Take(5); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1943") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(97) // skip this number of lines in the text file 
                                                       .Take(3); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1944") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(100) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1945") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(104) // skip this number of lines in the text file 
                                                       .Take(6); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1946") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(110) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1947") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(114) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1948") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(118) // skip this number of lines in the text file 
                                                       .Take(4); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1949") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(122) // skip this number of lines in the text file 
                                                       .Take(5); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1950") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(127) // skip this number of lines in the text file 
                                                       .Take(8); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1951") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(135) // skip this number of lines in the text file 
                                                       .Take(15); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1952") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(150) // skip this number of lines in the text file 
                                                       .Take(9); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1953") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(159) // skip this number of lines in the text file 
                                                       .Take(21); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1954") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(180) // skip this number of lines in the text file 
                                                       .Take(15); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1955") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(195) // skip this number of lines in the text file 
                                                       .Take(14); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1956") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(209) // skip this number of lines in the text file 
                                                       .Take(20); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1957") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(229) // skip this number of lines in the text file 
                                                       .Take(31); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1958") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(260) // skip this number of lines in the text file 
                                                       .Take(30); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1959") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(290) // skip this number of lines in the text file 
                                                       .Take(29); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1960") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(319) // skip this number of lines in the text file 
                                                       .Take(18); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1961") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(337) // skip this number of lines in the text file 
                                                       .Take(13); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1962") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(350) // skip this number of lines in the text file 
                                                       .Take(17); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1963") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(367) // skip this number of lines in the text file 
                                                       .Take(12); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1964") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(379) // skip this number of lines in the text file 
                                                       .Take(13); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1965") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(392) // skip this number of lines in the text file 
                                                       .Take(25); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1966") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(417) // skip this number of lines in the text file 
                                                       .Take(17); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1967") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(434) // skip this number of lines in the text file 
                                                       .Take(16); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1968") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(450) // skip this number of lines in the text file 
                                                       .Take(15); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1969") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(465) // skip this number of lines in the text file 
                                                       .Take(19); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1970") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(484) // skip this number of lines in the text file 
                                                       .Take(16); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1971") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(500) // skip this number of lines in the text file 
                                                       .Take(15); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1972") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(515) // skip this number of lines in the text file 
                                                       .Take(16); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1973") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(531) // skip this number of lines in the text file 
                                                       .Take(16); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1974") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(547) // skip this number of lines in the text file 
                                                       .Take(19); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1975") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(566) // skip this number of lines in the text file 
                                                       .Take(21); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1976") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(587) // skip this number of lines in the text file 
                                                       .Take(11); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1977") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(598) // skip this number of lines in the text file 
                                                       .Take(26); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1978") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(624) // skip this number of lines in the text file 
                                                       .Take(18); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1979") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(642) // skip this number of lines in the text file 
                                                       .Take(32); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1980") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(674) // skip this number of lines in the text file 
                                                       .Take(21); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1981") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(695) // skip this number of lines in the text file 
                                                       .Take(24); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1982") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(719) // skip this number of lines in the text file 
                                                       .Take(34); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1983") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(753) // skip this number of lines in the text file 
                                                       .Take(34); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1984") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(787) // skip this number of lines in the text file 
                                                       .Take(31); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1985") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(818) // skip this number of lines in the text file 
                                                       .Take(28); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1986") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(846) // skip this number of lines in the text file 
                                                       .Take(31); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1987") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(877) // skip this number of lines in the text file 
                                                       .Take(30); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1988") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(907) // skip this number of lines in the text file 
                                                       .Take(24); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1989") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(931) // skip this number of lines in the text file 
                                                       .Take(34); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1990") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(965) // skip this number of lines in the text file 
                                                       .Take(32); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1991") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(997) // skip this number of lines in the text file 
                                                       .Take(25); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1992") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1022) // skip this number of lines in the text file 
                                                       .Take(21); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1993") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1043) // skip this number of lines in the text file 
                                                       .Take(24); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1994") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1067) // skip this number of lines in the text file 
                                                       .Take(22); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1995") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1089) // skip this number of lines in the text file 
                                                       .Take(34); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1996") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1123) // skip this number of lines in the text file 
                                                       .Take(22); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1997") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1145) // skip this number of lines in the text file 
                                                       .Take(21); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1998") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1166) // skip this number of lines in the text file 
                                                       .Take(23); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "1999") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1189) // skip this number of lines in the text file 
                                                       .Take(23); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2000") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1212) // skip this number of lines in the text file 
                                                       .Take(21); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2001") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1233) // skip this number of lines in the text file 
                                                       .Take(25); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2002") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1258) // skip this number of lines in the text file 
                                                       .Take(65); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2003") // example year to use 
                {
                    {
                        listBox1.Items.Add("No movies to display");
                    }
                }
                if (listBox2.SelectedItem == "2004") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1323) // skip this number of lines in the text file 
                                                       .Take(35); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2005") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1358) // skip this number of lines in the text file 
                                                       .Take(31); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2006") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1389) // skip this number of lines in the text file 
                                                       .Take(35); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2007") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1424) // skip this number of lines in the text file 
                                                       .Take(27); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2008") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1451) // skip this number of lines in the text file 
                                                       .Take(33); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2009") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1484) // skip this number of lines in the text file 
                                                       .Take(41); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2010") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1525) // skip this number of lines in the text file 
                                                       .Take(35); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2011") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1560) // skip this number of lines in the text file 
                                                       .Take(41); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2012") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1601) // skip this number of lines in the text file 
                                                       .Take(32); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2013") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1633) // skip this number of lines in the text file 
                                                       .Take(36); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
                if (listBox2.SelectedItem == "2014") // example year to use 
                {
                    IEnumerable<string> result = lines.Skip(1669) // skip this number of lines in the text file 
                                                       .Take(18); // start from the line after the last number you skipped and read (21) lines down
                    foreach (string str in result)
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // use this to clear the previous years' movie results
            {
                var lines = File.ReadAllLines("MovieList.txt");
                foreach (var item in lines)
                {
                    listBox1.Items.Add(item); // adds all the movies before anything is selected 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // use this to clear the previous years' movie results
            {
                var lines = File.ReadAllLines("MovieList.txt");
                foreach (var item in lines)
                {
                    if (item.Contains(textBox1.Text))
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
        }
    }
}

