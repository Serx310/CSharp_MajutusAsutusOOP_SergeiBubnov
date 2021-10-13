using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Harjutus_07._10._2021
{
    class Hotell:MajutusAsutus
    {
        int _tubadearv;
        public Hotell(decimal hind, int kohti_toas) : base(hind, kohti_toas) {
            _tubadearv = 100;
        }

        public override int Reserveeri(int külalisi)
        {
            if (külalisi > VabuTube)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "Ei ole piisavalt vabu kohti");
            }
            if (külalisi < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(külalisi), "Ei tohi olla negatiivne arv");
            }
            VabuTube -= külalisi;
            return VabuTube;
        }

        public int VabuTube
        {
            get { return _tubadearv; }
            set { _tubadearv = value; }
        }
    }
}
