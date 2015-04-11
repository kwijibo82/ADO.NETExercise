using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparacionExamenExtraAD
{
    class BDErrores
    {
        public static String controlError(SqlException e)
        {
            String msg;
            switch (e.Number)
            {
                case 547:

                    msg = " Imposible eliminar, el registro ya existe en otra base de datos";
                    break;

                case 208:

                    msg = "Nombre o entrada de tabla incorrecta";

                    break;
                case 53:

                    msg = "Error, no se pudo establecer una coenxión con el servidor";
                    break;

                case 2601:
                case 2627:
                    msg = "El registro ya existe en la base de datos";
                    break;

                case 4060:
                    msg = "Error de base de datos";
                    break;

                case 18456:
                    msg = "nombre o usuario incorrecto";
                    break;


                default:
                    msg = e.Number + "   " + e.Message.ToString();
                    break;
            }
            return msg;
        }

    }
}
