using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Proy_pilas_colas
{
    class Vistadatos
    {

        public void mostrar_pila(ListBox lista, Stack pila, Label turno)
        {
            lista.Items.Clear();
            foreach (Persona item in pila)
                lista.Items.Add(item);

            
            if (pila.Count > 0)
            {
                turno.Text = String.Format("Turno: {0}", pila.Peek());
                
            }
            else
                turno.Text = "Sin elementos";
        }

        public void mostrar_cola(ListBox lista, Queue cola, Label turno)
        {
            lista.Items.Clear();
            foreach (Persona item in cola)
                lista.Items.Add(item);

            if (cola.Count > 0)
            {
                turno.Text = String.Format("Turno: {0}", cola.Peek());

            }
            else
                turno.Text = "Sin elementos";
        }
        

        
    }
}
