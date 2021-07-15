using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EjemploMedico.MedicoDataSetTableAdapters;
namespace EjemploMedico
{
    public partial class index : System.Web.UI.Page
    {
        string _nombre;
        Int16 _edad;
        Int16 _tipo;
        public index()
        {
            _nombre = string.Empty;
            _edad = 0;
            _tipo = 0;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Construir la vista
            FormularioPacienteSubmit.Text = StringsEstaticos.FRP_SUBMIT;
            LTipoSangre.DataSource = TipoSangre.ToList;
            LTipoSangre.DataBind();
            
        }

        protected void FormularioPacienteSubmit_Click(object sender, EventArgs e)
        {
            // Adaptador base de datos
            PacienteTableAdapter adapter = new PacienteTableAdapter();
            const string _strEspacio = " ";
            string[] _nombreCompleto = new string[] {
                TxtPrimerNombre.Text,
                _strEspacio,
                TxtPrimerApellido.Text,
                _strEspacio,
                TxtSegundoNombre.Text,
                _strEspacio,
                TxtSegundoApellido.Text
            };
            this._nombre = string.Concat(_nombreCompleto);
            this._tipo = TipoSangre.Parse(LTipoSangre.SelectedIndex);
            if (this._nombre.CompareTo(string.Empty) == 0) return;
            if (Int16.TryParse(TxtEdad.Text, out this._edad))
            {
                if (Int16.TryParse(
                    Math.Max(Math.Min(int.Parse(this._edad.ToString()), 0), 100)
                    .ToString(), out this._edad))
                    adapter.InsertarPaciente(0, this._nombre.ToString(), this._edad, this._tipo);
                else
                    Response.Write("<script>alert('La edad debe ser un número entre 0 y 100.');</script>");
            }
            else
                Response.Write("<script>alert('La edad debe ser un valor numerico.');</script>");
        }
    }
}