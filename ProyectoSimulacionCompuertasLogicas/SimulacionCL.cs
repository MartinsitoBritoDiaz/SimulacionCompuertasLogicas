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
            BitsTextBox.Text = "";
            ResultadoTextBox.Text = "";
            YEScheckBox.Checked = false;
            NOTcheckBox.Checked = false;      
            ANDcheckBox.Checked = false;    
            NANDcheckBox.Checked = false;    
            ORcheckBox.Checked = false;    
            NORcheckBox.Checked = false;    
            XORcheckBox.Checked = false;    
            XNORcheckBox.Checked = false;
            PrimerComboBox.SelectedIndex = -1;
            SegundoComboBox.SelectedIndex = -1;
            TercerComboBox.SelectedIndex = -1;
        }
        private void ValidarEntrada()
        {
            errorProvider.Clear();
            int Bits = 0;
            string Compuerta1 = "";
            string Compuerta2 = ""; 
            string Compuerta3 = "";

            if (String.Equals(PrimerComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            if (String.Equals(PrimerComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta1 = PrimerComboBox.Text;
            }

            //Segundo Combo------------------------------------
            if (String.Equals(SegundoComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Bits -= YES.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "NOT"))
            {
                Bits += NOT.CantidadPuertos;
                Bits -= NOT.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Bits -= AND.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Bits -= NAND.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Bits -= OR.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Bits -= NOR.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Bits -= XOR.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            if (String.Equals(SegundoComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Bits -= XNOR.CantidadSalida;
                Compuerta2 = SegundoComboBox.Text;
            }

            //Tercer Combo------------------------------------
            if (String.Equals(TercerComboBox.Text, "YES"))
            {
                Bits += YES.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "NOT"))
            { 
                Bits += NOT.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "AND"))
            {
                Bits += AND.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "NAND"))
            {
                Bits += NAND.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "OR"))
            {
                Bits += OR.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "NOR"))
            {
                Bits += NOR.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "XOR"))
            {
                Bits += XOR.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (String.Equals(TercerComboBox.Text, "XNOR"))
            {
                Bits += XNOR.CantidadPuertos;
                Compuerta3 = TercerComboBox.Text;
            }

            if (BitsTextBox.TextLength != Bits)
                errorProvider.SetError(BitsTextBox, "Debe de introducir los bits correspondientes a la cantidad de entradas de las compuertas");
            else
            {
                ResultadoTextBox.Text = Convert.ToString(ObtenerResultado3(Compuerta1,Compuerta2,Compuerta3, ObtenerResultado1(Compuerta1), ObtenerResultado2(Compuerta1 ,Compuerta2, ObtenerResultado1(Compuerta1))));
            }

        }

        public int ObtenerResultado1(string c1)
        {

            int resultado1 = 0;
            char[] arrayChar = BitsTextBox.Text.ToCharArray();

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
        public int ObtenerResultado2(string c1,string c,int resultado1)
        {
            int resultado2 = 0;
            int indice = 2;
            char[] arrayChar = BitsTextBox.Text.ToCharArray();

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

            if (String.Equals(c1, "YES") || (String.Equals(c1, "NOT")))
                indice = 1;

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
        public int ObtenerResultado3(string c1, string c2, string c, int resultado1, int resultado2)
        {
            int resultado3 = 0;
            int indice = 1;
            char[] arrayChar = BitsTextBox.Text.ToCharArray();

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
            if (!String.IsNullOrWhiteSpace(PrimerComboBox.Text))
                if (!String.IsNullOrWhiteSpace(SegundoComboBox.Text))
                    if (!String.IsNullOrWhiteSpace(TercerComboBox.Text))
                        InicioPictureBox.Visible = true;
                    else
                        InicioPictureBox.Visible = false;
                else
                    InicioPictureBox.Visible = false;
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

        void CambiarDatosCombo(bool paso, string NombreCL)
        {
            if (paso)
            {
                PrimerComboBox.Items.Add(NombreCL);
                SegundoComboBox.Items.Add(NombreCL);
                TercerComboBox.Items.Add(NombreCL);
            }
            else
            {
                PrimerComboBox.Items.Remove(NombreCL);
                SegundoComboBox.Items.Remove(NombreCL);
                TercerComboBox.Items.Remove(NombreCL);
            }
        }
        void EliminarOpciones(string seleccion)
        {
            TercerComboBox.Items.Remove(seleccion);
            SegundoComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones2(string seleccion)
        {
            PrimerComboBox.Items.Remove(seleccion);
            TercerComboBox.Items.Remove(seleccion);
        }

        void EliminarOpciones3(string seleccion)
        {
            PrimerComboBox.Items.Remove(seleccion);
            SegundoComboBox.Items.Remove(seleccion);
        }

        //CheckBox metodos checked changed para verificar que solo sean seleccionados 3
        private void YEScheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkedControls = this.Controls.OfType<CheckBox>()
                                   .Where(chk => chk.Checked == true);

            var uncheckedControls = this.Controls.OfType<CheckBox>()
                                                 .Where(chk => chk.Checked == false);

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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

            if (checkedControls.Count() > 2)
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
            EliminarOpciones(PrimerComboBox.Text);
            PrimerPictureBox.Image = AsignarImagenAlPictureBox(PrimerComboBox.Text);

            ValidarInicio();
        }

        private void SegundoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones2(SegundoComboBox.Text);
            SegundaPictureBox.Image = AsignarImagenAlPictureBox(SegundoComboBox.Text);
            ValidarInicio();

        }

        private void TercerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones3(TercerComboBox.Text);
            TerceraPictureBox.Image = AsignarImagenAlPictureBox(TercerComboBox.Text);
            ValidarInicio();

        }

        private void SimulacionCL_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ValidarEntrada();
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
    }
}
