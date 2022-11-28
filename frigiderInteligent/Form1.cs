using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frigiderInteligent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public persoana trufinalex = new persoana();
        public frigider frigiderArctic = new frigider();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            trufinalex.idpersoana = "001";
            trufinalex.nume = "trufin";
            trufinalex.prenume = "alex";
            trufinalex.telefon = "00400754357465";

            frigiderArctic.idpersoana = "001";
            frigiderArctic.idfrigider = "001";
            frigiderArctic.marca = "arctic";
            frigiderArctic.model = "model2021alaska";

        }

        public void printdatefrigider()
        {
            textBox4.Text += "Persoana : " + 
                            trufinalex.idpersoana + " : " +
                              trufinalex.nume + " : " +
                               trufinalex.prenume + " : " +
                                trufinalex.telefon + " : \r\n";
            textBox4.Text += "Frigider : " +
                            frigiderArctic.idpersoana + " : " +
                              frigiderArctic.idfrigider + " : " +
                               frigiderArctic.marca + " : " +
                                frigiderArctic.model + " : \r\n";
            textBox4.Text += "Produs : " +
                            frigiderArctic.produse[0].idprodus + " : " +
                              frigiderArctic.produse[0].denumire + " : " +
                               frigiderArctic.produse[0].dataexpirarii + " : " +
                                frigiderArctic.produse[0].dateprodus + " : \r\n";
            textBox4.Text += " Alerte : " +
                     frigiderArctic.alerte[0].idalerta + " : " +
                      frigiderArctic.alerte[0].idpersoana + " : " +
                       frigiderArctic.alerte[0].idprodus + " :  \r\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frigiderArctic.produse.Add(new produs(
                textBox3.Text, 
                textBox1.Text ,
                dateTimePicker1.Value.ToShortDateString().ToString(),
                textBox2.Text
                ));
            frigiderArctic.alerte.Add(new alerta(
                "001",
                trufinalex.idpersoana,
                frigiderArctic.produse[0].idprodus
                ));
            printdatefrigider();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
