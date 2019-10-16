using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter _usuarioData;

        public UsuarioAdapter UsuarioData
        {
            get { return _usuarioData; }
            set { _usuarioData = value; }
        }

        public UsuarioLogic()
        {
            UsuarioData = new UsuarioAdapter();
        }


        
    }
}
