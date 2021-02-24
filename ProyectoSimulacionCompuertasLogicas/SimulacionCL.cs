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
        private static byte[] YES;
        private static byte[] NOT;
        private static byte[] AND;
        private static byte[] NAND;
        private static byte[] OR;
        private static byte[] NOR;
        private static byte[] XOR;
        private static byte[] XNOR;

        public SimulacionCL()
        {
            InitializeComponent();
            AsignarImagenesByte();
        }

        private void AsignarImagenesByte()
        {
             YES = ImagenToArregloByte(YESPictureBox.Image);
             NOT = ImagenToArregloByte(NOTpictureBox.Image);
             AND = ImagenToArregloByte(ANDpictureBox.Image);
             NAND = ImagenToArregloByte(NANDpictureBox.Image);
             OR = ImagenToArregloByte(ORpictureBox.Image);
             NOR = ImagenToArregloByte(NORpictureBox.Image);
             XOR = ImagenToArregloByte(XORpictureBox.Image);
             XNOR = ImagenToArregloByte(XNORpictureBox.Image);
        }


        private Image AsignarImagenAlPictureBox(string cadenaCL)
        {
            if (String.Equals(cadenaCL, "YES"))
                return ArrgeloByteToImagen(YES);

            if (cadenaCL == "NOT")
                return ArrgeloByteToImagen(NOT);

            if (cadenaCL == "AND")
                return ArrgeloByteToImagen(AND);

            if (cadenaCL == "NAND")
                return ArrgeloByteToImagen(NAND);
            
            if (cadenaCL == "OR")
                return ArrgeloByteToImagen(OR);
            
            if (cadenaCL == "NOR")
                return ArrgeloByteToImagen(NOR);
            
            if (cadenaCL == "XOR")
                return ArrgeloByteToImagen(XOR);
             
            if (cadenaCL == "XNOR")
                return ArrgeloByteToImagen(XNOR);

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

            bool paso = YEScheckBox.Checked;

            CambiarDatosCombo(paso, "XNOR");
        }

        private void PrimerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones(PrimerComboBox.Text);
            PrimerPictureBox.Image = AsignarImagenAlPictureBox(PrimerComboBox.Text);
        }

        private void SegundoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones2(SegundoComboBox.Text);
            SegundaPictureBox.Image = AsignarImagenAlPictureBox(SegundoComboBox.Text);
        }

        private void TercerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EliminarOpciones3(TercerComboBox.Text);
            TerceraPictureBox.Image = AsignarImagenAlPictureBox(TercerComboBox.Text);
        }

        private void SimulacionCL_Load(object sender, EventArgs e)
        {

        }
    }
}
