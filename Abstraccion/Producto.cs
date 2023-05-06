using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public abstract class Producto
    {
        protected string Nombre_Producto;
        protected double Costo_Producto; // Miembro abstracto 
        protected double Precio_Producto;

        public Producto(string Nombre, double Costo, double Precio) // Es un constructor El publico no sabe si existe esta clase
        {
            Nombre_Producto = "Tu libro es: " + Nombre;
            Costo_Producto = Costo;
            Precio_Producto = Precio; 

        }
    }

    public class interactuar : Producto //Interactuar es la clase hijo y "Producto" es la clase padre
    {
        public interactuar(string Nombre, double Costo, double Precio): base (Nombre, Costo, Precio) //Se crea un constructor y se hace herencia Esta clase se manda a traer
        {

        }

        public string Imprime_dato()
        {
            return Nombre_Producto + "El precio es: " + Precio_Producto; 

        }
    }
}
