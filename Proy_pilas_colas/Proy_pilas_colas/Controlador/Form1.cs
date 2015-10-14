using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Proy_pilas_colas
{
    public partial class Form1 : Form
    {
        Stack pila = new Stack();
        Queue cola = new Queue();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Agregar a la cola
            cola.Enqueue(new Persona(txtItem.Text));
            //Agregar a la pila
            pila.Push(new Persona(txtItem.Text));
            txtItem.Text = "";
            mostrar_datos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                cola.Dequeue();
                pila.Pop();
            }
            else
                MessageBox.Show("No hay elemento a remover", "Pilas & Colas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrar_datos();
        }

        private void mostrar_datos()
        {
            Vistadatos v = new Vistadatos();
            v.mostrar_pila(lbPila, pila, lbTurnoPila);
            v.mostrar_cola(lbCola, cola, lbTurnoCola);
            lbCantidad.Text = String.Format("Elementos: {0}",pila.Count);
           
        }
    }
}
