namespace WinFormsApp1
{
    public partial class Form1 : Form
        
    {
    
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            //Para decirle al bot�n que abra los archivos
            imagen.Title = "FOTO";
            //T�tulo del visor
            imagen.Filter = "Archivos de Imagen(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp";
            //Los tipos de archivos que acepta
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                string ruta;
                ruta = imagen.FileName;
                PicImagen.Image = Image.FromFile(ruta);
            }
            //Esto dice que cuando le des a aceptar que abra la imagen que seleccionaste
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Num3 = float.Parse(txtNum3.Text);
            //Declaramos las variables que vamos a utilizar

            float resultado = ((Num1 + Num2 + Num3) / 3);
            txtresult.Text = resultado.ToString();
            //Aqui le decimos a la compu que combierta nuestro int a string para poder representarlo en la pantalla escrito
            if (resultado < 7)
            {
                veredicto.Text = "No Acreditado";
            }
            else
            {
                veredicto.Text = "Acreditado";
            }
            //En las l�neas de c�digo anteriores b�sicamente estamos diciendo a la compu
            //Que si el promedio es menor a 7 ponga que no acredit� y si es mayor que ponga que si acredit�
        }

        private void label10_Click(object sender, EventArgs e)

        {
            float Num1 = float.Parse(txtNum1.Text);
            float Num2 = float.Parse(txtNum2.Text);
            float Num3 = float.Parse(txtNum3.Text);

            float resultado = ((Num1 + Num2 + Num3) / 3);
            if (resultado < 0)
            {
                //Continuar� aqu� m�s tarde
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            //En C# tenemos que primero crear el objeto y le estamos diciendo a la compu que "creditos" es igual al segundo fomulario que cree (que en
            //este caso se llama "Creditos") as� hereda todas las funciones que podr�a tener cualquier formulario
            creditos.Show();
            //Esto es para que al momento de apretar el bot�n me abra el nuevo formulario
            //En este caso el fomulario es "creditos"
        }
    }

}