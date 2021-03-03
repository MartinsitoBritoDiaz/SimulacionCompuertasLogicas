using ProyectoSimulacionCompuertasLogicas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSimulacionCompuertasLogicas
{
    public partial class SimulacionCL : Form
    {
        CompuertasLogicas YES = new CompuertasLogicas("YES", 1,1);
        CompuertasLogicas NOT = new CompuertasLogicas("NOT", 1, 1);
        CompuertasLogicas AND = new CompuertasLogicas("AND", 2, 1);
        CompuertasLogicas NAND = new CompuertasLogicas("NAND", 2, 1);
        CompuertasLogicas OR = new CompuertasLogicas("OR", 2, 1);
        CompuertasLogicas NOR = new CompuertasLogicas("NOR", 2, 1);
        CompuertasLogicas XOR = new CompuertasLogicas("XOR", 2, 1);
        CompuertasLogicas XNOR = new CompuertasLogicas("XNOR", 2, 1);

        public SimulacionCL()
        {
            InitializeComponent();
            AsignarImagenesByte();
        }

        private void Limpiar()
        {
            Bits1TextBox.Text = "";
            Bits2TextBox.Text = "";
            ResultadoFila1TextBox.Text = "";
            ResultadoFila2TextBox.Text = "";
            ResultadoColumna1TextBox.Text = "";
            ResultadoColumna2TextBox.Text = "";
            ResultadoColumna3TextBox.Text = "";
            YEScheckBox.Checked = false;
            NOTcheckBox.Checked = false;      
            ANDcheckBox.Checked = false;    
            NANDcheckBox.Checked = false;    
            ORcheckBox.Checked = false;    
            NORcheckBox.Checked = false;    
            XORcheckBox.Checked = false;    
            XNORcheckBox.Checked = false;
            Primer1ComboBox.SelectedIndex = -1;
            Segundo1ComboBox.SelectedIndex = -1;
            Tercer1ComboBox.SelectedIndex = -1;
            Primer2ComboBox.SelectedIndex = -1;
            Segundo2ComboBox.SelectedIndex = -1;
            Tercer2ComboBox.SelectedIndex = -1;
        }
        private void ValidarEntrada()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = ""; 
            string Compuerta3 = "";

            if (String.Equals(Primer1ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            //Segundo Combo------------------------------------
            if (String.Equals(Segundo1ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = Segundo1ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Tercer1ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "NOT"))
            { 
                Bits += NOT.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = Tercer1ComboBox.Text;
            }
            
            bool paso = true;

            if (Bits1TextBox.TextLength != Bits)
                errorProvider.SetError(Bits1TextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoFila1TextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1, Compuerta2, Compuerta3, ObtenerResultado1(Compuerta1, paso), ObtenerResultado2(Compuerta1, Compuerta2, ObtenerResultado1(Compuerta1, paso), paso), paso));
            }

        }


        private void ValidarEntrada2()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = "";
            string Compuerta3 = "";

            if (String.Equals(Primer2ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = Primer2ComboBox.Text;
            }

            //Segundo Combo------------------------------------
            if (String.Equals(Segundo2ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Tercer2ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = Tercer2ComboBox.Text;
            }

            bool paso = false;

            if (Bits2TextBox.TextLength != Bits)
                errorProvider.SetError(Bits2TextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoFila2TextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1, Compuerta2, Compuerta3, ObtenerResultado1(Compuerta1, paso), ObtenerResultado2(Compuerta1, Compuerta2, ObtenerResultado1(Compuerta1,paso),paso),paso));
            }

        }

        private void ValidarEntrada3()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = "";
            string Compuerta3 = "";

            if (String.Equals(Primer3ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = Primer3ComboBox.Text;
            }

            //Segundo Combo------------------------------------
            if (String.Equals(Segundo3ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = Segundo3ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Tercer3ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            bool paso = false;

            if (Bits3TextBox.TextLength != Bits)
                errorProvider.SetError(Bits3TextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoFila3TextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1, Compuerta2, Compuerta3, ObtenerResultado1(Compuerta1, paso), ObtenerResultado2(Compuerta1, Compuerta2, ObtenerResultado1(Compuerta1, paso), paso), paso));
            }

        }


        private void ValidarColumna1()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = "";
            string Compuerta3 = "";

            if (String.Equals(Primer1ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            if (String.Equals(Primer1ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = Primer1ComboBox.Text;
            }

            //Segundo Combo------------------------------------
            if (String.Equals(Primer2ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            if (String.Equals(Primer2ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = Primer2ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Primer3ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            if (String.Equals(Primer3ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = Primer3ComboBox.Text;
            }

            bool paso = true;

            if (Bits1TextBox.TextLength != Bits)
                errorProvider.SetError(ResultadoColumna1TextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoColumna1TextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1, Compuerta2, Compuerta3, ObtenerResultado1(Compuerta1, paso), ObtenerResultado2(Compuerta1, Compuerta2, ObtenerResultado1(Compuerta1, paso), paso), paso));
            }
        }

        private void ValidarColumna2()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = "";
            string Compuerta3 = "";

            if (String.Equals(Segundo1ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            if (String.Equals(Segundo1ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = Segundo1ComboBox.Text;
            }

            //Segundo Combo------------------------------------
            if (String.Equals(Segundo2ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            if (String.Equals(Segundo2ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = Segundo2ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Segundo3ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            if (String.Equals(Segundo3ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = Segundo3ComboBox.Text;
            }

            bool paso = true;

            if (Bits2TextBox.TextLength != Bits)
                errorProvider.SetError(ResultadoColumna2TextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoColumna2TextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1, Compuerta2, Compuerta3, ObtenerResultado1(Compuerta1, paso), ObtenerResultado2(Compuerta1, Compuerta2, ObtenerResultado1(Compuerta1, paso), paso), paso));
            }
        }

        private void ValidarColumna3()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = "";
            string Compuerta3 = "";

            if (String.Equals(Tercer1ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            if (String.Equals(Tercer1ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = Tercer1ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Tercer2ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            if (String.Equals(Tercer2ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = Tercer2ComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(Tercer3ComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            if (String.Equals(Tercer3ComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = Tercer3ComboBox.Text;
            }

            bool paso = true;

            if (Bits3TextBox.TextLength != Bits)
                errorProvider.SetError(ResultadoColumna2TextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoColumna2TextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1, Compuerta2, Compuerta3, ObtenerResultado1(Compuerta1, paso), ObtenerResultado2(Compuerta1, Compuerta2, ObtenerResultado1(Compuerta1, paso), paso), paso));
            }
        }


        public int ObtenerResultado1(string c1, bool paso)
        {

            int resultado1 = 0;
            char[] arrayChar;

            if(paso)
                arrayChar = Bits1TextBox.Text.ToCharArray();
            else
                arrayChar = Bits2TextBox.Text.ToCharArray();


            if (String.Equals(c1, "YES"))
            {
                if (arrayChar[0] == '1')
                    resultado1 = 1;
                else
                    resultado1 = 0;
            }

            if (String.Equals(c1, "NOT"))
            {
                if (arrayChar[0] == '1')
                    resultado1 = 0;
                else
                    resultado1 = 1;
            }

            if (String.Equals(c1, "AND"))
            {
                if (arrayChar[0] == '1' && arrayChar[1] == '1')
                    resultado1 = 1;
                else
                    resultado1 = 0;
            }

            if (String.Equals(c1, "NAND"))
            {
                if (arrayChar[0] == '1' && arrayChar[1] == '1')
                    resultado1 = 0;
                else
                    resultado1 = 1;
            }

            if (String.Equals(c1, "OR"))
            {
                if (arrayChar[0] == '0' && arrayChar[1] == '0')
                    resultado1 = 0;
                else
                    resultado1 = 1;
            }

            if (String.Equals(c1, "NOR"))
            {
                if (arrayChar[0] == '0' && arrayChar[1] == '0')
                    resultado1 = 1;
                else
                    resultado1 = 0;
            }

            if (String.Equals(c1, "XOR"))
            {
                if (arrayChar[0] == '0' && arrayChar[1] == '0')
                    resultado1 = 0;
                else 
                    if (arrayChar[0] == '1' && arrayChar[1] == '1')
                        resultado1 = 0;
                    else
                        resultado1 = 1;
            }

            if (String.Equals(c1, "XNOR"))
            {
                if (arrayChar[0] == '0' && arrayChar[1] == '0')
                    resultado1 = 1;
                else
                    if (arrayChar[0] == '1' && arrayChar[1] == '1')
                    resultado1 = 1;
                else
                    resultado1 = 0;

            } return resultado1;
        }

       
        public int ObtenerResultado2(string c1,string c,int resultado1, bool paso)
        {
            int resultado2 = 0;
            int indice = 2;
            char[] arrayChar;

            if (paso)
                arrayChar = Bits1TextBox.Text.ToCharArray();
            else
                arrayChar = Bits2TextBox.Text.ToCharArray();

            
            if (String.Equals(c1, "YES") || (String.Equals(c1, "NOT")))
                indice = 1;


            if (String.Equals(c, "YES"))
            {
                if (resultado1 == 1)
                    resultado2 = 1;
                else
                    resultado2 = 0;
            }

            if (String.Equals(c, "NOT"))
            {
                if (resultado1 == 1)
                    resultado2 = 0;
                else
                    resultado2 = 1;
            }

            if (String.Equals(c, "AND"))
            {
                if (arrayChar[indice] == '1' && resultado1 == 1)
                    resultado2 = 1;
                else
                    resultado2 = 0;
            }

            if (String.Equals(c, "NAND"))
            {
                if (arrayChar[indice] == '1' && resultado1 == 1)
                    resultado2 = 0;
                else
                    resultado2 = 1;
            }

            if (String.Equals(c, "OR"))
            {
                if (arrayChar[indice] == '0' && resultado1 == 0)
                    resultado2 = 0;
                else
                    resultado2 = 1;
            }

            if (String.Equals(c, "NOR"))
            {
                if (arrayChar[indice] == '0' && resultado1 == 0)
                    resultado2 = 1;
                else
                    resultado2 = 0;
            }

            if (String.Equals(c, "XOR"))
            {
                if (arrayChar[indice] == '0' && resultado1 == 0)
                    resultado2 = 0;
                else
                    if (arrayChar[indice] == '1' && resultado1 == 1)
                    resultado2 = 0;
                else
                    resultado2 = 1;
            }

            if (String.Equals(c, "XNOR"))
            {
                if (arrayChar[indice] == '0' && resultado1 == 0)
                    resultado2 = 1;
                else
                    if (arrayChar[indice] == '1' && resultado1 == 1)
                    resultado2 = 1;
                else
                    resultado2 = 0;

            }


            return resultado2;
        }
        public int ObtenerResultado3(string c1, string c2, string c, int resultado1, int resultado2, bool paso)
        {
            int resultado3 = 0;
            int indice = 1;
            char[] arrayChar;

            if (paso)
                arrayChar = Bits1TextBox.Text.ToCharArray();
            else
                arrayChar = Bits2TextBox.Text.ToCharArray();

            if (String.Equals(c, "YES"))
            {
                if (resultado2 == 1)
                    resultado3 = 1;
                else
                    resultado3 = 0;
            }

            if (String.Equals(c, "NOT"))
            {
                if (resultado2 == 1)
                    resultado3 = 0;
                else
                    resultado3 = 1;
            }

            if ((!String.Equals(c1, "YES") || !String.Equals(c1, "NOT")) && (String.Equals(c2, "YES") || String.Equals(c2, "NOT")))
                indice = 2;
            else
                if ((String.Equals(c1, "YES") || String.Equals(c1, "NOT")) && (!String.Equals(c2, "YES") || !String.Equals(c2, "NOT")))
                    indice = 2;
                else
                    if ((!String.Equals(c1, "YES") || !String.Equals(c1, "NOT")) && (!String.Equals(c2, "YES") || !String.Equals(c2, "NOT")))
                        indice = 3;

            if ((String.Equals(c1, "YES") || String.Equals(c1, "NOT")) && (String.Equals(c2, "YES") || String.Equals(c2, "NOT")))
                indice = 1;

                if (String.Equals(c, "AND"))
                {
                    if (arrayChar[indice] == '1' && resultado2 == 1)
                        resultado3 = 1;
                    else
                        resultado3 = 0;
                }

            if (String.Equals(c, "NAND"))
            {
                if (arrayChar[indice] == '1' && resultado2 == 1)
                    resultado3 = 0;
                else
                    resultado3 = 1;
            }

            if (String.Equals(c, "OR"))
            {
                if (arrayChar[indice] == '0' && resultado2 == 0)
                    resultado3 = 0;
                else
                    resultado3 = 1;
            }

            if (String.Equals(c, "NOR"))
            {
                if (arrayChar[indice] == '0' && resultado2 == 0)
                    resultado3 = 1;
                else
                    resultado3 = 0;
            }

            if (String.Equals(c, "XOR"))
            {
                if (arrayChar[indice] == '0' && resultado2 == 0)
                    resultado3 = 0;
                else
                    if (arrayChar[indice] == '1' && resultado1 == 1)
                    resultado3 = 0;
                else
                    resultado3 = 1;
            }

            if (String.Equals(c, "XNOR"))
            {
                if (arrayChar[indice] == '0' && resultado2 == 0)
                    resultado3 = 1;
                else
                    if (arrayChar[indice] == '1' && resultado2 == 1)
                    resultado3 = 1;
                else
                    resultado3 = 0;

            }
            return resultado3;
        }
        private void AsignarImagenesByte()
        {
             YES.Imagen = ImagenToArregloByte(YESPictureBox.Image);
             NOT.Imagen = ImagenToArregloByte(NOTpictureBox.Image);
             AND.Imagen = ImagenToArregloByte(ANDpictureBox.Image);
             NAND.Imagen = ImagenToArregloByte(NANDpictureBox.Image);
             OR.Imagen = ImagenToArregloByte(ORpictureBox.Image);
             NOR.Imagen = ImagenToArregloByte(NORpictureBox.Image);
             XOR.Imagen = ImagenToArregloByte(XORpictureBox.Image);
             XNOR.Imagen = ImagenToArregloByte(XNORpictureBox.Image);
        }

        private void ValidarInicio()
        {
            if (!String.IsNullOrWhiteSpace(Primer1ComboBox.Text) && !String.IsNullOrWhiteSpace(Segundo1ComboBox.Text) && !String.IsNullOrWhiteSpace(Tercer1ComboBox.Text)) 
                InicioPictureBox.Visible = true;
            else
                InicioPictureBox.Visible = false;
        }

        private Image AsignarImagenAlPictureBox(string cadenaCL)
        {
            if (String.Equals(cadenaCL, "YES"))
                return ArrgeloByteToImagen(YES.Imagen);

            if (String.Equals(cadenaCL, "NOT"))
                return ArrgeloByteToImagen(NOT.Imagen);

            if (String.Equals(cadenaCL, "AND"))
                return ArrgeloByteToImagen(AND.Imagen);

            if (String.Equals(cadenaCL, "NAND"))
                return ArrgeloByteToImagen(NAND.Imagen);
            
            if (String.Equals(cadenaCL, "OR"))
                return ArrgeloByteToImagen(OR.Imagen);
            
            if (String.Equals(cadenaCL, "NOR"))
                return ArrgeloByteToImagen(NOR.Imagen);
            
            if (String.Equals(cadenaCL, "XOR"))
                return ArrgeloByteToImagen(XOR.Imagen);
             
            if (String.Equals(cadenaCL, "XNOR"))
                return ArrgeloByteToImagen(XNOR.Imagen);

            return null;

        }

        private Image ArrgeloByteToImagen(byte[] ArregloByte)//Esta funcion convierte el arreglo de bytes que se guarda en la base de datos a la imagen 
        {

            MemoryStream ms = new MemoryStream(ArregloByte);
            Image retornaImagen = Image.FromStream(ms);
            return retornaImagen;
        }

        public byte[] ImagenToArregloByte(System.Drawing.Image imageIn)//Esta funcion convierte la imagen en un arreglo de bytes para poder guardarla en la base de datos
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        //Funcion para agregar las compuertas a los combos.
        void CambiarDatosCombo(bool paso, string NombreCL)
        {
            if (paso)
            {
                Primer1ComboBox.Items.Add(NombreCL);
                Segundo1ComboBox.Items.Add(NombreCL);
                Tercer1ComboBox.Items.Add(NombreCL);

                Primer2ComboBox.Items.Add(NombreCL);
                Segundo2ComboBox.Items.Add(NombreCL);
                Tercer2ComboBox.Items.Add(NombreCL);

                Primer3ComboBox.Items.Add(NombreCL);
                Segundo3ComboBox.Items.Add(NombreCL);
                Tercer3ComboBox.Items.Add(NombreCL);
            }
            else
            {
                Primer1ComboBox.Items.Remove(NombreCL);
                Segundo1ComboBox.Items.Remove(NombreCL);
                Tercer1ComboBox.Items.Remove(NombreCL);

                Primer2ComboBox.Items.Remove(NombreCL);
                Segundo2ComboBox.Items.Remove(NombreCL);
                Tercer2ComboBox.Items.Remove(NombreCL);

                Primer3ComboBox.Items.Remove(NombreCL);
                Segundo3ComboBox.Items.Remove(NombreCL);
                Tercer3ComboBox.Items.Remove(NombreCL);
            }
        }

        //Funciones para no repetir las compuertas en una misma fila.
        void EliminarOpciones(string seleccion)
        {
            Tercer1ComboBox.Items.Remove(seleccion);
            Segundo1ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones2(string seleccion)
        {
            Primer1ComboBox.Items.Remove(seleccion);
            Tercer1ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones3(string seleccion)
        {
            Primer1ComboBox.Items.Remove(seleccion);
            Segundo1ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones21(string seleccion)
        {
            Tercer2ComboBox.Items.Remove(seleccion);
            Segundo2ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones22(string seleccion)
        {
            Primer2ComboBox.Items.Remove(seleccion);
            Tercer2ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones23(string seleccion)
        {
            Primer2ComboBox.Items.Remove(seleccion);
            Segundo2ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones31(string seleccion)
        {
            Tercer3ComboBox.Items.Remove(seleccion);
            Segundo3ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones32(string seleccion)
        {
            Primer3ComboBox.Items.Remove(seleccion);
            Tercer3ComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones33(string seleccion)
        {
            Primer3ComboBox.Items.Remove(seleccion);
            Segundo3ComboBox.Items.Remove(seleccion);
        }


        //CheckBox metodos checked changed para verificar que solo sean seleccionados 3
        private void YEScheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = YEScheckBox.Checked;

            CambiarDatosCombo(paso, "YES");
            ValidarInicio();
        }

        private void NOTcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = NOTcheckBox.Checked;

            CambiarDatosCombo(paso, "NOT");
            ValidarInicio();

        }

        private void ANDcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = ANDcheckBox.Checked;

            CambiarDatosCombo(paso, "AND");
            ValidarInicio();

        }

        private void NANDcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = NANDcheckBox.Checked;

            CambiarDatosCombo(paso, "NAND");
            ValidarInicio();

        }

        private void ORcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = ORcheckBox.Checked;

            CambiarDatosCombo(paso, "OR");
            ValidarInicio();

        }

        private void NORcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = NORcheckBox.Checked;

            CambiarDatosCombo(paso, "NOR");
            ValidarInicio();

        }

        private void XORcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = XORcheckBox.Checked;

            CambiarDatosCombo(paso, "XOR");
            ValidarInicio();

        }

        private void XNORcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 5)
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = false;
            }
            else
            {
                foreach (CheckBox chkBox in uncheckedControls) chkBox.Enabled = true;
            }

            bool paso = XNORcheckBox.Checked;

            CambiarDatosCombo(paso, "XNOR");
            ValidarInicio();

        }

        private void PrimerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones(Primer1ComboBox.Text);
            Primer1PictureBox.Image = AsignarImagenAlPictureBox(Primer1ComboBox.Text);

            ValidarInicio();
        }

        private void SegundoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones2(Segundo1ComboBox.Text);
            Segunda1PictureBox.Image = AsignarImagenAlPictureBox(Segundo1ComboBox.Text);
            ValidarInicio();

        }

        private void TercerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones3(Tercer1ComboBox.Text);
            Tercera1PictureBox.Image = AsignarImagenAlPictureBox(Tercer1ComboBox.Text);
            ValidarInicio();

        }

        private void SimulacionCL_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ValidarEntrada();

            if (!String.IsNullOrWhiteSpace(Primer2ComboBox.Text) && !String.IsNullOrWhiteSpace(Segundo2ComboBox.Text) && !String.IsNullOrWhiteSpace(Tercer2ComboBox.Text))
                ValidarEntrada2();

            if (!String.IsNullOrWhiteSpace(Primer3ComboBox.Text) && !String.IsNullOrWhiteSpace(Segundo3ComboBox.Text) && !String.IsNullOrWhiteSpace(Tercer3ComboBox.Text))
                ValidarEntrada3();

            if (!String.IsNullOrWhiteSpace(Primer1ComboBox.Text) && !String.IsNullOrWhiteSpace(Primer2ComboBox.Text) && !String.IsNullOrWhiteSpace(Primer3ComboBox.Text))
                ValidarColumna1();

            if (!String.IsNullOrWhiteSpace(Segundo1ComboBox.Text) && !String.IsNullOrWhiteSpace(Segundo2ComboBox.Text) && !String.IsNullOrWhiteSpace(Segundo3ComboBox.Text))
                ValidarColumna2();

            if (!String.IsNullOrWhiteSpace(Tercer1ComboBox.Text) && !String.IsNullOrWhiteSpace(Tercer2ComboBox.Text) && !String.IsNullOrWhiteSpace(Tercer3ComboBox.Text))
                ValidarColumna3();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validKeys = new[] { Keys.Back, Keys.D0, Keys.D1 };

            e.Handled = !validKeys.Contains((Keys)e.KeyChar);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Primer2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones21(Primer2ComboBox.Text);
            Primer2PictureBox.Image = AsignarImagenAlPictureBox(Primer2ComboBox.Text);

            ValidarInicio();
        }

        private void Segundo2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones22(Segundo2ComboBox.Text);
            Segunda2PictureBox.Image = AsignarImagenAlPictureBox(Segundo2ComboBox.Text);

            ValidarInicio();
        }

        private void Tercer2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones23(Tercer2ComboBox.Text);
            Tercera2PictureBox.Image = AsignarImagenAlPictureBox(Tercer2ComboBox.Text);

            ValidarInicio();
        }

        private void Primer2PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Primer3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones31(Primer3ComboBox.Text);
            Primer3PictureBox.Image = AsignarImagenAlPictureBox(Primer3ComboBox.Text);

            ValidarInicio();
        }

        private void ResultadoFila2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultadoFila3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Segundo3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones32(Segundo3ComboBox.Text);
            Segunda3PictureBox.Image = AsignarImagenAlPictureBox(Segundo3ComboBox.Text);

            ValidarInicio();
        }

        private void Tercer3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones33(Tercer3ComboBox.Text);
            Tercera3PictureBox.Image = AsignarImagenAlPictureBox(Tercer3ComboBox.Text);

            ValidarInicio();
        }
    }
}
