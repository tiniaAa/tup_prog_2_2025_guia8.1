using Ejercicio1.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Empleado> empleados = new List<Empleado>();
        Empleado empleado;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            lbxEmpleados.Items.Clear();
            foreach (Empleado ep in empleados)
            {
                lbxEmpleados.Items.Add(ep);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos|*.*";

            FileStream fs = null;
            StreamReader sr = null;

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string name = ofd.FileName;
                    fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    Regex regex = new Regex(@"^(Asalariado|Jornalero);");
                    sr.ReadLine();
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {


                        string linea = sr.ReadLine().Trim();
                        Match match = regex.Match(linea);
                        if (match.Success)
                        {
                            string[] cadEmpleados = linea.Split(';');

                            if (cadEmpleados.Length == 5)
                            {
                                string tipo = cadEmpleados[0];
                                int dni = Convert.ToInt32(cadEmpleados[1]);
                                string nombre = cadEmpleados[2];
                                double basico = Convert.ToDouble(cadEmpleados[3]);
                                double aporte = Convert.ToDouble(cadEmpleados[4]);

                                empleados.Sort();
                                empleado = new Asalariado(dni, nombre, basico, aporte);
                                int idx = empleados.BinarySearch(empleado);

                                if (idx >= null)
                                {
                                    Asalariado asalariado = empleados[idx] as Asalariado;
                                    asalariado.Basico += basico;
                                }
                                else
                                {

                                    empleados.Add(empleado);
                                }


                            }
                            else if (cadEmpleados.Length == 6)
                            {
                                string tipo = cadEmpleados[0];
                                int dni = Convert.ToInt32(cadEmpleados[1]);
                                string nombre = cadEmpleados[2];
                                int horas = Convert.ToInt32(cadEmpleados[3]);
                                double ImportPorHora = Convert.ToDouble(cadEmpleados[4]);
                                double retenciones = Convert.ToDouble(cadEmpleados[5]);
                                empleado = new Jornalero(dni, nombre, horas, ImportPorHora, retenciones);
                                empleados.Sort();

                                int idx = empleados.BinarySearch(empleado);
                                if (idx >= 0)
                                {
                                    Jornalero jornalero = empleados[idx] as Jornalero;
                                    jornalero.ImportePorHora += ImportPorHora;
                                }
                                else
                                {
                                    empleados.Add(empleado);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }



        }

        private void lbxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Empleado empleado = lbxEmpleados.SelectedItem as Empleado;
            
            if (empleado != null)
            {
                form2.textBox1.Text += "----------------------- "+Environment.NewLine;
                foreach (string l in empleado.GenerarRecibo())
                {
                    form2.textBox1.Text += l+Environment.NewLine;
                }
                form2.textBox1.Text += "-----------------------"+ Environment.NewLine;
            }

            form2.ShowDialog();

        }
    }
}
