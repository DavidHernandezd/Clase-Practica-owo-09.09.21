using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngetname_Click(object sender, EventArgs e)
        {
            selectname();
        }

        // metodo para obtener los nombres de la coleccion

        private void selectname()
        {
            List<string> query = (
                from student in Student.GetStudents()
                select student.firstname
                ).ToList();
            //recorrer lista y llenar el lstNames   
            foreach (var name in query)
            {
                //llenar lstnames
                lstnames.Items.Add(name);
            }
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            //agregar columnas al datagridvew
            dgv.Columns.Add("idstudent", "CODIGO");
            dgv.Columns.Add("firstname", "NOMBRE");
            dgv.Columns.Add("lastname", "APELLIDO");
            dgv.Columns.Add("age", "EDAD");
            dgv.Columns.Add("country", "PAIS");

            foreach (var student in selectalldata())
            {
                dgv.Rows.Add(student.idstudent, student.firstname, student.lastname, student.age, student.country);
            }
        }
        //metodo para consultar los datos
        private List<Student> selectalldata()
        {
            List<Student> query = (
                from Student in Student.GetStudents()
                select new Student()
                {
                    idstudent = Student.idstudent,
                    firstname = Student.firstname,
                    lastname = Student.lastname,
                    age = Student.age,
                    country = Student.country,
                }
                ).ToList();
            return query;
        }
    }
}
