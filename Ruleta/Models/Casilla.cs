using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta.Models
{
    public class Casilla
    {

        public enum COLOR {ROJO, NEGRO, VERDE };
        public enum PARIDAD { PAR, IMPAR, CERO }
        public enum MAYORIA { MENOR, MAYOR, CERO}
        public enum DOCENA { PRIMERA, SEGUNDA, TERCERA, CERO }
        public enum COLUMNA  { PRIMERA, SEGUNDA, TERCERA, CERO }
        

        public int Numero { get;  } // SI es CERO, todas las demas propiedades son -1
        public COLOR Color { get; private set; }  //cero es rojo, uno en negro
        public PARIDAD Paridad { get; private set;  } //cero es par, uno es impar
        public MAYORIA Mayoria { get; private set; } // cero es menor, uno es mayor; 
        public DOCENA Docena { get; private set;  }
        public COLUMNA Columna { get; private set; }
        public int Fila { get; private set; }

        public Casilla(int numero)
        {

            Numero = numero;
            // Assigna el COLOR correspondiente al numero y VERDE al cero (o doble cero)
            SetColor();

            //Asigna la paridad
            SetParidad();

            //Asigna la MAyoria
            SetMayoria();

            //Assigna la Docena
            SetDocena(numero);

            //Assigna la Columna
            SetColumna();

            //Asigna la fila
            SetFila();
        }

        public override string ToString()
        {
            string _numero = Numero.ToString() + " - ";
            _numero += Color.ToString() + " - " ;
            _numero += Paridad.ToString() + " - ";
            _numero += Mayoria.ToString() + " - ";
            _numero += Docena.ToString() + " - ";
            _numero += Columna.ToString() + " - ";
            _numero += Fila.ToString();

            return _numero;
        }

        #region Metodos Privados

        private void SetFila()
        {
            Fila = (Numero != 0) ? (Numero / 3) + 1 : -1;
        }

        private void SetColumna()
        {
            if (Numero == 0) { Columna = COLUMNA.CERO; }
            else if (Numero % 3 == 0) { Columna = COLUMNA.PRIMERA; }
            else if (Numero % 3 == 1) { Columna = COLUMNA.SEGUNDA; }
            else { Columna = COLUMNA.TERCERA; }
        }

        private void SetDocena(int numero)
        {
            if (Numero == 0) { Docena = DOCENA.CERO; }
            else if (Numero <= 12) { Docena = DOCENA.PRIMERA; }
            else if (Numero > 12 && numero <= 24) { Docena = DOCENA.SEGUNDA; }
            else { Docena = DOCENA.TERCERA; }
        }

        private void SetMayoria()
        {
            if (Numero == 0) { Mayoria = MAYORIA.CERO; }
            else if (Numero <= 18) { Mayoria = MAYORIA.MENOR; }
            else { Mayoria = MAYORIA.MAYOR; }
        }

        private void SetParidad()
        {
            if (Numero == 0) { Paridad = PARIDAD.CERO; }
            else if (Numero % 2 == 0) { Paridad = PARIDAD.PAR; }
            else { Paridad = PARIDAD.IMPAR; }
        }

        private void SetColor()
        {
            switch (Numero)
            {
                case 0: Color = COLOR.VERDE; break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 12:
                case 14:
                case 16:
                case 18:
                case 19:
                case 21:
                case 23:
                case 25:
                case 27:
                case 30:
                case 32:
                case 34:
                case 36:
                    Color = COLOR.ROJO;
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                case 11:
                case 13:
                case 15:
                case 17:
                case 20:
                case 22:
                case 24:
                case 26:
                case 28:
                case 29:
                case 31:
                case 33:
                case 35:
                    Color = COLOR.NEGRO;
                    break;
            }
        }

        #endregion
    }
}
