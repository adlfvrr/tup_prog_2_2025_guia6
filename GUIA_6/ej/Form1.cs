using ej.Models;
namespace ej
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List <Persona> personas = new List<Persona> ();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ModalDatos fDatos = new ModalDatos();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombre = fDatos.tbP.Text;
                    Persona p = null;
                    if (fDatos.radioButton1.Checked)
                    {
                        p = new Persona(nombre);
                    }
                    else if (fDatos.radioButton2.Checked)
                    {
                        string cuit = fDatos.tbPJuridica.Text;
                        p = new PersonaJuridica(nombre, cuit);
                    }
                }
                catch (FormatoCUITNoValidoException ex) 
                {
                    fDatos.
                }
                if (p != null)
                {
                    personas.Add (p);   
                }
                else
                {
                    MessageBox.Show("Debe elegir el tipo");
                }
            }
            Actualizar();
        }
        protected void Actualizar()
        {
            lsbPersonas.Items.Clear();
            foreach(Persona persona in personas)
            {
                lsbPersonas.Items.Add(persona.Describir());
            }
        }
    }
}
